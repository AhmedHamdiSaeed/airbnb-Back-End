using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.ReviewRepo
{
	public interface IReviewRepository:IGenericRepository<Review>
	{
		Task<IEnumerable<Review>> GetAllUserReviews(string userid);
		Task<IEnumerable<Review>> GetAllBookingReviews(int bookingid);
		Task<Review> GetUserReviewDetails(int reviewId);
		Task<bool> AnyAsync(Expression<Func<Review, bool>> predicate);

	}
}
