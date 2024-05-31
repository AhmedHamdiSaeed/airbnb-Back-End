using AirBnb.BL.Dtos.ReviewsDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
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
		public ReviewManager(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}

		public async Task<bool> AddReview(string userid,ReviewsAddDto review)
		{
			Review result = new Review
			{
				UserId = userid,
				Rating = review.Rating,
				Comment = review.Comment,
			};

			await _unitOfWork.ReviewRepository.AddAsync(result);
			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<bool> DeleteReview(int reviewId)
		{
			Review result = await _unitOfWork.ReviewRepository.GetByIdAsync(reviewId);
			 _unitOfWork.ReviewRepository.Delete(result);
			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<IEnumerable<ReviewsGetDto>> GetAllBookingReviews(int bookingid)
		{
			IEnumerable<Review> reviews =await _unitOfWork.ReviewRepository.GetAllBookingReviews(bookingid);
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
				BookingId= singleReviewData.BookingId,
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
