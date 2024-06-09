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

		public async Task<PaggenationReslut> GetAllPropertyForAdmin(int pageSize, int pageNumber, int? cityId = null, int? cateId = null)
		{

			var query = _context.Set<Property>().AsNoTracking().AsQueryable();

			if (cityId.HasValue)
			{
				query = query.Where(p => p.CityId == cityId.Value);
			}
			if (cateId.HasValue)
			{
				query = query.Where(p => p.CategoryId == cateId.Value);
			}
			int quantity = await query.CountAsync();
			;
			query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
			return new PaggenationReslut { Quantity = quantity, Properties = query };
		}

		public async Task<PaggenationReslut> GetAllPropertyForAllUsers(int pageNumber, int pageSize, int? cityId = null, int? cateId = null)
		{
			
			var query = _context.Set<Property>().Where(x=>x.Status==Status.Confirmed).AsNoTracking().AsQueryable();

			if (cityId.HasValue)
			{
				query = query.Where(p => p.CityId == cityId.Value);
			}
			if (cateId.HasValue)
			{
				query = query.Where(p => p.CategoryId == cateId.Value);
			}
			int quantity=await query.CountAsync();
			;
			query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
			return new PaggenationReslut {Quantity= quantity,Properties=query };
		}

		

		public async Task<IEnumerable<Property>> GetHosterProperties(string hosterId)
		{
			return await _context.Set<Property>().AsNoTracking().Where(x=>x.UserId==hosterId).ToListAsync();
		}

		public async Task<Property> GetPropertyDetailsById(int propId)
		{
			return await _context.Set<Property>().Include(x=>x.City).Include(x=>x.Category).Include(x => x.PropertyImages).Include(x=>x.User).Include(x => x.Amenity).Include(x => x.AppointmentsAvailable).FirstOrDefaultAsync(p => p.Id == propId);
		}

		public async Task<Property> GetPropertyToDeleteById(int id)
		{
			return await _context.Set<Property>()
				.Include(p => p.PropertyBokking).Include(p => p.AppointmentsAvailable)
				.FirstOrDefaultAsync(p => p.Id == id);
		}
	}
}
