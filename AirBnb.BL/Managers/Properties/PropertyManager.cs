using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Properties
{
	public class PropertyManager : IPropertyManager
	{
		private readonly IUnitOfWork _unitOfWork;
		public PropertyManager(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;

		}

		public async Task<bool> AddProperty(PropertyAddDto addProperty, string userId)
		{
			Property newProp = new Property()
			{
				Name = addProperty.Name,
				Description = addProperty.Description,
				Adress = addProperty.Adress,
				NumberOfBathrooms = Convert.ToInt32(addProperty.NumberOfBathrooms),
				NumberOfBedrooms = Convert.ToInt32(addProperty.NumberOfBedrooms),
				DisplayedImage = addProperty.DisplayedImage,
				Beds = Convert.ToInt32(addProperty.Beds),
				UserId = userId,
				CategoryId = Convert.ToInt32(addProperty.CategoryId),
				CityId = Convert.ToInt32(addProperty.CityId),
				Status = Status.Pending,
				CheckIn = TimeOnly.Parse(addProperty.CheckIn),
				CheckOut = TimeOnly.Parse(addProperty.CheckOut),
				NumberOfGuest = Convert.ToInt32(addProperty.NumberOfGuest),
				Pets = Convert.ToBoolean(Convert.ToInt32(addProperty.Pets)),
				TakePhotos = Convert.ToBoolean(Convert.ToInt32(addProperty.TakePhotos)),

			};
			await _unitOfWork.PropertyRepository.AddAsync(newProp);
			return  _unitOfWork.SaveChanges() > 0;
			
		}

		public async Task<PaggenationsResultDto> GetAllPropertyForAdmin(int pageNumber, int pageSize, int? cityId = null, int? cateId = null)
		{
			PaggenationReslut AllProperty = await _unitOfWork.PropertyRepository.GetAllPropertyForAdmin( pageNumber,  pageSize, cityId, cateId);
			if (AllProperty is null)
				return null;

			var result = new PaggenationsResultDto
			{
				Quantity = AllProperty.Quantity,
				Properties = AllProperty.Properties.Select(p => new PropertyGetDto
				{
					Id = p.Id,
					Name = p.Name,
					DisplayedImage = p.DisplayedImage,
					Description = p.Description,

				})
			};
			return result;
		}

		public async Task<PaggenationsResultDto> GetAllPropertyForAllUsers(int pageNumber, int pageSize, int? cityId = null, int? cateId = null)
		{
			PaggenationReslut AllProperty = await _unitOfWork.PropertyRepository.GetAllPropertyForAllUsers( pageNumber,  pageSize, cityId, cateId);
			if (AllProperty is null)
				return null;

			var result = new PaggenationsResultDto
			{
				Quantity = AllProperty.Quantity,
				Properties = AllProperty.Properties.Select(p => new PropertyGetDto
				{
					Id = p.Id,
					Name = p.Name,
					DisplayedImage = p.DisplayedImage,
					Description = p.Description,

				})
			};
			return result;
		}

		public async Task<IEnumerable<PropertyGetDto>> GetHosterProperties(string hosterId)
		{
			IEnumerable<Property> allProp =await _unitOfWork.PropertyRepository.GetHosterProperties(hosterId);

			if(allProp is null) return null;

			var result = allProp.Select(pro => new PropertyGetDto
			{
				Id = pro.Id,
				Name = pro.Name,
				DisplayedImage = pro.DisplayedImage,
				Description = pro.Description,

			});
			return result;
		}

		public async Task<PropertyDetailsGetDto> GetPropertyDetailsById(int propId)
		{
			Property singleProp = await _unitOfWork.PropertyRepository.GetPropertyDetailsById(propId);

			if (singleProp == null)
			{
				// Handle the case where the property is not found
				return null; // Or throw an exception, return a default DTO, etc.
			}

			// Initialize the result DTO
			PropertyDetailsGetDto result = new PropertyDetailsGetDto
			{
				Name = singleProp.Name,
				Description = singleProp.Description,
				
				Adress = singleProp.Adress,
				NumberOfBathrooms = singleProp.NumberOfBathrooms,
				NumberOfBedrooms = singleProp.NumberOfBedrooms,
				DisplayedImage = singleProp.DisplayedImage,
				Beds = singleProp.Beds,
				UserName = $"{singleProp.User?.FirstName ?? string.Empty} {singleProp.User?.LastName ?? string.Empty}",
				UserImage = singleProp.User?.Image,
				CategoryName = singleProp.Category?.Name,
				CityName = singleProp.City?.Name,
				NumberOfGuest = singleProp.NumberOfGuest,
				Pets = singleProp.Pets,
				TakePhotos = singleProp.TakePhotos,
				CheckIn = singleProp.CheckIn,
				CheckOut = singleProp.CheckOut,
				ImageUrl = singleProp.PropertyImages?.Select(img => new Dtos.PropertyImagesDtos.PropertyImagesGet
				{
					Id = img.Id,
					ImageUrl = img.ImageUrl,
					PropertyId = img.PropertyId,
				}).ToList(),
				Reviews = singleProp.PropertyBokking?.SelectMany(b => b.Reviews?.Select(rev => new ReviewForProperty
				{
					ReviewId = rev.Id,
					ReviewUserName = rev.UserReview?.FirstName,
					ReviewUserImage = rev.UserReview?.Image,
					ReviewComment = rev.Comment
				})).ToList(),
				Amentities = singleProp.Amenity?.Select(am => new PropAmentity
				{
					Id = am.Id,
					Name = am.Name,
					Description = am.Description
				}).ToList(),
				AppoinmentAvaiable = singleProp.AppointmentsAvailable?.Select(app => new PropAppoinmentAvailable
				{
					Id= app.Id,
					PropertyId= app.PropertyId,
					From = app.From,
					To = app.To,
					TotalProice= (int)((int)((app.To - app.From).TotalDays) * app.PricePerNight),
					PricePerNight = app.PricePerNight,
					IsAvailable = app.IsAvailable,
				}).ToList(),
				BookingDates = null
			};

			return result;
		}

		public async Task<bool> RemoveProperty(int propertyId)
		{
			Property singleProp = await _unitOfWork.PropertyRepository.GetPropertyDetailsById(propertyId);
			if (singleProp == null)
			{
				return false;
			}
			_unitOfWork.PropertyRepository.Delete(singleProp);
			return _unitOfWork.SaveChanges()>0;
		}

		public async Task<bool> UpdatePropertyByHoster(int propId, PropertyUpdateDto updateProperty)
		{
			Property prop =await _unitOfWork.PropertyRepository.GetByIdAsync(propId);
			if(prop == null)
			{ return false; }
			prop.Name = updateProperty.Name;
			prop.Description = updateProperty.Description;
			prop.Adress = updateProperty.Adress;
			prop.NumberOfBathrooms = Convert.ToInt32(updateProperty.NumberOfBathrooms);
			prop.NumberOfBedrooms	= Convert.ToInt32(updateProperty.NumberOfBedrooms);
			prop.DisplayedImage= updateProperty.DisplayedImage;
			prop.Beds = Convert.ToInt32(updateProperty.Beds);
			prop.UserId= prop.UserId;
			prop.CategoryId = Convert.ToInt32(updateProperty.CategoryId);
			prop.CityId = Convert.ToInt32(updateProperty.CityId);

			_unitOfWork.PropertyRepository.Update(prop);
			return _unitOfWork.SaveChanges() > 0;
		}






		//
		public async Task<bool> UpdatePropertyByAdmin(int propId, PropertyUpdateByAdminDto updateProperty)
		{
			Property prop = await _unitOfWork.PropertyRepository.GetByIdAsync(propId);
			if (prop == null)
			{ return false; }
			
			if (prop.Status == Status.Canceled) return false;
			prop.Status = updateProperty.PropertStatus;
			_unitOfWork.PropertyRepository.Update(prop);
			return _unitOfWork.SaveChanges() > 0;
		}
	}
}
