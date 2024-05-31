using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.ReviewRepo
{
	public class ReviewRepository:GenericRepository<Review>,IReviewRepository
	{
        private readonly AppDbContext _context;
        public ReviewRepository(AppDbContext context):base(context) 
        {
			_context=context;

		}

		public async Task<IEnumerable<Review>> GetAllUserReviews(string userid)
		{
			return await _context.Set<Review>().AsNoTracking().Where(x=>x.UserId==userid).ToListAsync();
		}
		public async Task<IEnumerable<Review>> GetAllBookingReviews(int bookingid)
		{
			return await _context.Set<Review>().AsNoTracking().Where(x => x.BookingId == bookingid).ToListAsync();
		}

		public async Task<Review> GetUserReviewDetails(int reviewId)
		{
			return await _context.Set<Review>().Include(x=>x.Booking).FirstOrDefaultAsync(x=>x.Id== reviewId);
		}
	}
}
