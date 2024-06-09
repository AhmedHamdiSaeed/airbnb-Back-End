using AirBnb.BL.Dtos.PropertyImagesDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.PropertiesImages
{
	public class PropertyImagesManager : IPropertyImagesManager
	{
		private readonly IUnitOfWork _manager;
        public PropertyImagesManager(IUnitOfWork manager)
        {
			_manager=manager;

		}
        public async Task<bool> AddImage(PropertyImagesAddAndUpdate AddImage)
		{
			PropertyImage NewImage = new PropertyImage()
			{
				PropertyId= AddImage.PropertyId,
				ImageUrl = AddImage.ImageUrl,
			};
			await _manager.PropertyImagesRepository.AddAsync(NewImage);
			return _manager.SaveChanges() > 0;
		}

		public async Task<bool> DeleteImage(int propId)
		{
			PropertyImage DelImage =await _manager.PropertyImagesRepository.GetByIdAsync(propId);
			if( DelImage != null ) { return false; }
			 _manager.PropertyImagesRepository.Delete(DelImage);
			return _manager.SaveChanges() > 0;
		}

		public async Task<IEnumerable<PropertyImagesGet>> GetAllPropertyImagesForProperty(int propId)
		{
			IEnumerable<PropertyImage> getAllBasedOnPropId =await _manager.PropertyImagesRepository.GetAllPropertyImagesForProperty(propId);
			if( getAllBasedOnPropId == null ) { return null; };

			var result = getAllBasedOnPropId.Select(x => new PropertyImagesGet
			{
				PropertyId = x.PropertyId,
				ImageUrl = x.ImageUrl,
			});
			return result;
		}

		public async Task<bool> UpdateImage(int propId, PropertyImagesAddAndUpdate propImage)
		{
			PropertyImage Result = await _manager.PropertyImagesRepository.GetByIdAsync(propId);
			if (Result == null)
			{
				return false;
			}
			Result.PropertyId = propImage.PropertyId;
			Result.ImageUrl = propImage.ImageUrl;
			_manager.PropertyImagesRepository.Update(Result);
			return _manager.SaveChanges() > 0;
		}
	}
}
