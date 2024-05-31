using AirBnb.BL.Dtos.ReviewsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Reviews
{
	public interface IReviewManager
	{
		Task<IEnumerable<ReviewsGetDto>> GetAllBookingReviews(int bookingid);
		Task<IEnumerable<ReviewsGetDto>> GetAllUserReviews(string userid);
		Task<ReviewsGetDto> GetReviewDetails(int reviewId);
		Task<bool> UpdateReview(int reviewId,ReviewsUpdateDto review);
		Task<bool> DeleteReview(int reviewId);
		Task<bool> AddReview(string userid, ReviewsAddDto review);
	}
}
