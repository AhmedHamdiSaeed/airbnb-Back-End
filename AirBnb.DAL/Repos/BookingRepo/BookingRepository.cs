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

		public async Task<IEnumerable<Booking>> GetAllUserBooking(string userid)
		{
			return await _context.Set<Booking>().AsNoTracking().Where(x=>x.UserId==userid).ToListAsync();
		}

		public async Task<Booking> GetUserBookingetails(string userid)
		{
			return await _context.Set<Booking>().Include(x=>x.Property).FirstOrDefaultAsync(x=>x.UserId==userid);
		}
	}
}
