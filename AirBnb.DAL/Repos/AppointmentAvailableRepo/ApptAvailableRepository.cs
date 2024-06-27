using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.AppointmentAvailableRepo
{
	public class ApptAvailableRepository : GenericRepository<AppointmentsAvailable>, IApptAvailableRepository
	{
		private readonly AppDbContext _context;

		public ApptAvailableRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<IEnumerable<AppointmentsAvailable>> GetAllAppoinmentAvailable(int propId)
		{
			return await _context.Set<AppointmentsAvailable>().Where(x=>x.PropertyId==propId).AsNoTracking().ToListAsync();	
		}
		public async Task<AppointmentsAvailable> GetByPropertyIdAsync(int propertyId)
		{
			return await _context.Set<AppointmentsAvailable>()
								 .FirstOrDefaultAsync(a => a.PropertyId == propertyId);
		}


	}
}
