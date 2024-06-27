using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.BL.Dtos.PropertyDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Properties
{
	public interface IPropertyManager
	{
		Task<PaggenationsResultDto> GetAllPropertyForAllUsers(int pageNumber, int pageSize, int? cityId = null, int? cateId = null);
		Task<PropertyDetailsGetDto> GetPropertyDetailsById(int propId);
		Task<IEnumerable<PropertyGetDto>> GetHosterProperties(string hosterId);
		Task<bool> AddProperty(PropertyAddDto addProperty,string userId);
		Task<bool> RemoveProperty(int propertyId);
		public Task<bool> UpdatePropertyByHoster(int propId, PropertyUpdateDto updateProperty);
		public Task<bool> UpdatePropertyByAdmin(int propId, PropertyUpdateByAdminDto updateProperty);

		// Admin
		Task<PaggenationsResultDto> GetAllPropertyForAdmin(int pageNumber, int pageSize, int? cityId = null, int? cateId = null);

	}
}
