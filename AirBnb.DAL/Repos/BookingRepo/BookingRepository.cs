using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.BookingRepo
{
	public class BookingRepository : GenericRepository<Booking>, IBookingRepository
	{
		private readonly AppDbContext _context;
		public BookingRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Booking>> GetAllBookingForProperty(int propertyId)
		{
			return await _context.Set<Booking>().Include(x=>x.Property).Where(x => x.PropertyId == propertyId && x.BookingStatus==0).AsNoTracking().ToListAsync();
		}

		public async Task<IEnumerable<Booking>> GetAllUserBooking(string userid)
		{
			return await _context.Set<Booking>().Where(x=>x.UserId==userid).Include(x=>x.Property).AsNoTracking().ToListAsync();
		}

		public async Task<Booking> getBookingByIdWithData(int bookingId)
		{
			return await _context.Set<Booking>().Include(x => x.User).FirstOrDefaultAsync(x => x.Id == bookingId);
		}

		public async Task<IEnumerable<Booking>> GetPropertyBookingDetails(int propertyId)
		{
			return await  _context.Set<Booking>().Include(x=>x.User).Include(x=>x.Property).Where(x => x.PropertyId == propertyId).AsNoTracking().ToListAsync();
		}

		public async Task<Booking> GetUserBookingetails(int bookingid)
		{
			return await _context.Set<Booking>().Include(x=>x.Property).FirstOrDefaultAsync(x=>x.Id == bookingid);
		}
		//hgfhfg
		public async Task<Booking> GetUserBookingetail(int bookingid)
		{
			return await _context.Set<Booking>().FirstOrDefaultAsync(x => x.Id == bookingid);

		}

		public  void UpdateBooking(Booking booking)
		{
			 _context.Set<Booking>().Update(booking);
		}

		public async Task<IEnumerable<Booking>> GetBookingsByUserAndPropertyAsync(string userId, int propertyId)
		{
			return await _context.Set<Booking>()
						.Where(b => b.UserId == userId && b.PropertyId == propertyId)
						.ToListAsync();
		}
		public async Task<Booking> GetByIdAsync(string userId, int propertyId)
		{
			return await _context.Set<Booking>()
			   .FirstOrDefaultAsync(b => b.UserId == userId && b.PropertyId == propertyId);

		}
		public async Task<Booking> GetBookingByUserAndPropertyAsync(string userId, int propertyId)
		{
			return await _context.Set<Booking>()
				.FirstOrDefaultAsync(b => b.UserId == userId && b.PropertyId == propertyId);
		}
	}
}
