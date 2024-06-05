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
		Task<IEnumerable<DisplayAllPropertyDto>> GetAllProperty();
		Task<GetPropertyDetailsDto> GetPropertyDetailsById(int propertyId);
		Task<bool> AddProperty(AddPropertyDto addProperty);
		Task<bool> RemoveProperty(int propertyId);
	}
}
