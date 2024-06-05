using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PropertyRepo
{
	public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
	{
		private readonly AppDbContext _context;
		public PropertyRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public void DeleteProperty(Property entity)
		{
			_context.Set<Booking>().RemoveRange(entity.PropertyBokking);
			_context.Set<AppointmentsAvailable>().RemoveRange(entity.AppointmentsAvailable);
			_context.Set<Property>().Remove(entity);
			_context.SaveChanges();
		}

		public async Task<IEnumerable<Property>> GetAllPropertyAsync()
		{
			return await _context.Set<Property>()
				.Include(p => p.City)
				.AsNoTracking().ToListAsync();
		}

		public async Task<Property> GetProperty(int id)
		{
			return await _context.Set<Property>()
				.Include(p => p.User)
				.Include(p => p.City).ThenInclude(c => c.Country)
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<Property> GetPropertyToDeleteById(int id)
		{
			return await _context.Set<Property>()
				.Include(p => p.PropertyBokking).Include(p => p.AppointmentsAvailable)
				.FirstOrDefaultAsync(p => p.Id == id);
		}
	}
}
