using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.AmentityRepo
{
	public class AmentityRepository : GenericRepository<Amenity>, IAmentityRepository
	{
		private readonly AppDbContext _context;
		public AmentityRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
