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
				NumberOfBathrooms = addProperty.NumberOfBathrooms,
				NumberOfBedrooms = addProperty.NumberOfBedrooms,
				DisplayedImage = addProperty.DisplayedImage,
				Beds = addProperty.Beds,
				UserId = userId,
				CategoryId = addProperty.CategoryId,
				CityId = addProperty.CityId,
				Status = Status.Pending,
				CheckIn = new TimeOnly(addProperty.CheckIn),
				CheckOut = new TimeOnly(addProperty.CheckOut),
				NumberOfGuest = addProperty.NumberOfGuest,
				Pets = addProperty.Pets,
				TakePhotos = addProperty.TakePhotos,

			};
			await _unitOfWork.PropertyRepository.AddAsync(newProp);
			return  _unitOfWork.SaveChanges() > 0;
			
		}

		public async Task<PaggenationsResultDto> GetAllPropertyForAdmin(int pageNumber, int pageSize, int? cityId = null, int? cateId = null)
		{
			PaggenationReslut AllProperty = await _unitOfWork.PropertyRepository.GetAllPropertyForAdmin(pageNumber, pageSize, cityId, cateId);
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
			Property singleProp =await _unitOfWork.PropertyRepository.GetPropertyDetailsById(propId);
			PropertyDetailsGetDto result = new PropertyDetailsGetDto();
			result.Name = singleProp.Name;
			result.Description = singleProp.Description;
			result.Adress = singleProp.Adress;
			result.NumberOfBathrooms = singleProp.NumberOfBathrooms;
			result.NumberOfBedrooms = singleProp.NumberOfBedrooms;
			result.DisplayedImage = singleProp.DisplayedImage;
			result.Beds= singleProp.Beds;
			result.UserName=singleProp.User.FirstName;
			result.CategoryName = singleProp.Category.Name;
			result.CityName = singleProp.City.Name;
			result.CheckIn = singleProp.CheckIn;
			result.CheckOut = singleProp.CheckOut;
			result.NumberOfGuest=singleProp.NumberOfGuest;
			result.Pets=singleProp.Pets;
			result.TakePhotos=singleProp.TakePhotos;
			result.ImageUrl = singleProp.PropertyImages.Select(img => new Dtos.PropertyImagesDtos.PropertyImagesGet
			{
				Id = img.Id,
				ImageUrl = img.ImageUrl,
				PropertyId = img.PropertyId,
			}).ToList();
			result.Amentities = singleProp.Amenity.Select(am => new PropAmentity
			{
				Id=am.Id,
				Name = am.Name,
				Description = am.Description
			}).ToList();
			result.AppoinmentAvaiable = singleProp.AppointmentsAvailable.Select(app=> new PropAppoinmentAvailable
			{
				Id=app.Id,
				From = app.From,
				To = app.To,
				PricePerNight=app.PricePerNight,
				IsAvailable=app.IsAvailable,
			}).ToList();

			return result;
		}

		public async Task<bool> RemoveProperty(int propertyId)
		{
			var res = await _unitOfWork.PropertyRepository.GetPropertyToDeleteById(propertyId);
			var bookings = res.PropertyBokking.ToList();

			bool hasActiveOrFutureBookings = bookings.Any(booking =>
				(booking.CheckInDate <= DateTime.Now && booking.CheckOutDate >= DateTime.Now) || // Ongoing booking
				booking.CheckInDate > DateTime.Now);

			if (hasActiveOrFutureBookings)
			{
				// If there are future bookings, set property to unavailable for future bookings only
				foreach (var appointment in res.AppointmentsAvailable)
				{
					appointment.IsAvailable = false;
				}


				return _unitOfWork.SaveChanges() > 0; // Update successful
			}
			else
			{
				// If no future bookings, proceed with setting appointments to unavailable and deleting property
				foreach (var appointment in res.AppointmentsAvailable)
				{
					appointment.IsAvailable = false;
				}

				_unitOfWork.PropertyRepository.DeleteProperty(res);
				return _unitOfWork.SaveChanges() > 0; // Deletion successful
			}
		}

	}
}
