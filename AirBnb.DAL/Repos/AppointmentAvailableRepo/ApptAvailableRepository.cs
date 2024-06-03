using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.AppointmentAvailableRepo
{
	public class ApptAvailableRepository : GenericRepository<AppointmentsAvailable>, IApptAvailableRepository
	{
		public ApptAvailableRepository(AppDbContext context) : base(context)
		{
		}
	}
}
