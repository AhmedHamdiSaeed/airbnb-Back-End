using AirBnb.BL.Dtos.ReviewsDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Reviews
{
	public class ReviewManager:IReviewManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly ILogger<ReviewManager> _logger;

		public ReviewManager(IUnitOfWork unitOfWork, ILogger<ReviewManager> logger)
		{
			_unitOfWork = unitOfWork;
			_logger = logger;
		}

		public async Task<bool> AddReview(int BookingId,string userId, ReviewsAddDto review)
		{
			//var checkForReview = await CheckForReview(review.PropertyId, userId);
			//if (!checkForReview.HasReview)
			//{
			//	return false;
			//}

			// Create a new Review object
			var newReview = new Review
			{
				UserId = userId,
				//PropertyId = review.PropertyId,
				BookingId = BookingId,
				Rating = review.Rating,
				Comment = review.Comment,
			};

			// Add the new review to the repository
			await _unitOfWork.ReviewRepository.AddAsync(newReview);


			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<CheckForReviewDto> CheckForReview(int propertyId, string userId)
		{
			if (string.IsNullOrEmpty(userId))
			{
				return new CheckForReviewDto { HasReview = false, BookingId = null };
			}

			// Get bookings for the user and property
			var eligibleBookings = await _unitOfWork.BookingRepository.GetBookingsByUserAndPropertyAsync(userId, propertyId);

			// Check if the user has any bookings that have ended
			var eligibleBooking = eligibleBookings.FirstOrDefault(x => x.CheckOutDate >= DateTime.Now);

			if (eligibleBooking == null)
			{
				return new CheckForReviewDto { HasReview = false, BookingId = null };
			}

			// Check if a review exists for this booking
			var reviewExists = await _unitOfWork.ReviewRepository.AnyAsync(r => r.BookingId == eligibleBooking.Id && r.UserId == userId);

			if (!reviewExists)
			{
				return new CheckForReviewDto { HasReview = true, BookingId = eligibleBooking.Id };
			}

			return new CheckForReviewDto { HasReview = false, BookingId = null };
		}

		public async Task<bool> CheckReviewEligibility(string userId, int propertyId)
		{
			var bookings = await _unitOfWork.BookingRepository.GetAllUserBooking(userId);

			// Check if there is any booking that matches the propertyId and is eligible for review
			var isEligible = bookings.Any(b => b.PropertyId == propertyId && b.CheckOutDate <= DateTime.Now);

			return isEligible;
		}

		public async Task<bool> DeleteReview(int reviewId)
		{
			Review result = await _unitOfWork.ReviewRepository.GetByIdAsync(reviewId);
			_unitOfWork.ReviewRepository.Delete(result);
			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<IEnumerable<ReviewsGetDto>> GetAllBookingReviews(int bookingid)
		{
			IEnumerable<Review> reviews = await _unitOfWork.ReviewRepository.GetAllBookingReviews(bookingid);
			var result = reviews.Select(x => new ReviewsGetDto
			{
				Id = x.Id,
				BookingId = x.BookingId,
				Rating = x.Rating,
				Comment = x.Comment,
			}
			);
			return result;
		}

		public async Task<IEnumerable<ReviewsGetDto>> GetAllUserReviews(string userid)
		{

			IEnumerable<Review> reviews = await _unitOfWork.ReviewRepository.GetAllUserReviews(userid);
			var result = reviews.Select(x => new ReviewsGetDto
			{
				Id = x.Id,
				BookingId = x.BookingId,
				Rating = x.Rating,
				Comment = x.Comment,
			}
			);
			return result;
		}

		public async Task<ReviewsGetDto> GetReviewDetails(int reviewId)
		{
			Review singleReviewData = await _unitOfWork.ReviewRepository.GetByIdAsync(reviewId);
			if (singleReviewData is null)
			{
				return null;
			}

			ReviewsGetDto result = new ReviewsGetDto
			{
				Id = singleReviewData.Id,
				BookingId = singleReviewData.BookingId,
				Rating = singleReviewData.Rating,
				Comment = singleReviewData.Comment,
			};
			return result;
		}

		public async Task<bool> UpdateReview(int reviewId, ReviewsUpdateDto review)
		{
			Review singleReviewData = await _unitOfWork.ReviewRepository.GetByIdAsync(reviewId);
			if (singleReviewData is null)
			{
				return false;
			}
			singleReviewData.Rating = review.Rating;
			singleReviewData.Comment = review.Comment;
			_unitOfWork.ReviewRepository.Update(singleReviewData);
			return _unitOfWork.SaveChanges() > 0;
		}
	}






}
