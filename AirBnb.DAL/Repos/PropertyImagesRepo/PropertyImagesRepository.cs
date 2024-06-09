using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PropertyImagesRepo
{
	public class PropertyImagesRepository:GenericRepository<PropertyImage>,IPropertyImagesRepository
	{
        private readonly AppDbContext _appDbContext;
        public PropertyImagesRepository(AppDbContext context):base(context) 
        {
			_appDbContext=context;

		}

		public async Task<IEnumerable<PropertyImage>> GetAllPropertyImagesForProperty(int propId)
		{
			return await _appDbContext.Set<PropertyImage>().Where(x=>x.PropertyId==propId).AsNoTracking().ToListAsync();
		}
	}
}
