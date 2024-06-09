using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.BL.Dtos.PropertyImagesDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.PropertiesImages
{
	public interface IPropertyImagesManager
	{
		public Task<IEnumerable<PropertyImagesGet>> GetAllPropertyImagesForProperty(int propId);
		public Task<bool> AddImage(PropertyImagesAddAndUpdate AddImage);
		public Task<bool> DeleteImage(int propId);
		public Task<bool> UpdateImage(int propId, PropertyImagesAddAndUpdate propImage);

	}
}
