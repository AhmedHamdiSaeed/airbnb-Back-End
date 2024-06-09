using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PropertyImagesRepo
{
	public interface IPropertyImagesRepository : IGenericRepository<PropertyImage>
	{
		public Task<IEnumerable<PropertyImage>> GetAllPropertyImagesForProperty(int propId);
	}
}
