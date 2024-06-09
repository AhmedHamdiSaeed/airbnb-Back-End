using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PropertyRepo
{
	public interface IPropertyRepository : IGenericRepository<Property>
	{
		Task<PaggenationReslut> GetAllPropertyForAllUsers(int pageSize,int pageNumber,int? cityId = null, int? cateId = null);
		Task<Property> GetPropertyDetailsById(int propId);
		Task<IEnumerable<Property>> GetHosterProperties(string hosterId);
		Task<Property> GetPropertyToDeleteById(int id);
		void DeleteProperty(Property entity);


		//Admin
		Task<PaggenationReslut> GetAllPropertyForAdmin(int pageSize, int pageNumber, int? cityId = null, int? cateId = null);

	}
}
