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

		public async Task<bool> AddProperty(AddPropertyDto addProperty)
		{
			Property property = new Property
			{
				UserId = addProperty.UserId,
				Name = addProperty.Name,
				NumberOfBedrooms = addProperty.NumberOfBedrooms,
				NumberOfBathrooms = addProperty.NumberOfBathrooms,
				Beds = addProperty.Beds,
				CategoryId = addProperty.CategoryId,
				CityId = addProperty.CityId,
				Adress = addProperty.Adress,
				Description = addProperty.Description,
				Status = addProperty.Status,
				AppointmentsAvailable = addProperty.AppointmentsAvailable.Select(a => new AppointmentsAvailable
				{
					From = a.StartTime,
					To = a.EndTime,
					PricePerNight = a.PricePerNight,
					IsAvailable = true
				}).ToList()

			};
			await _unitOfWork.PropertyRepository.AddAsync(property);
			return _unitOfWork.SaveChanges() > 0;

		}

		public async Task<IEnumerable<DisplayAllPropertyDto>> GetAllProperty()
		{
			var properties = await _unitOfWork.PropertyRepository.GetAllPropertyAsync();
			if (properties == null) { return null; }

			var res = properties.Select(p => new DisplayAllPropertyDto
			{
				Id = p.Id,
				Name = p.Name,
				City = p.City.Name,
			});
			return res;
		}

		public async Task<GetPropertyDetailsDto> GetPropertyDetailsById(int propertyId)
		{
			var property = await _unitOfWork.PropertyRepository.GetByIdAsync(propertyId);
			var user = await _unitOfWork.UserRepository.GetUserByIdAsync(property.UserId);
			var cityInfo = await _unitOfWork.CityPrpository.GetcountrywithCities(property.CityId);

			if (property == null) { return null; };


			return new GetPropertyDetailsDto
			{
				Name = property.Name,
				Description = property.Description,
				Adress = property.Adress,
				NumberOfBathrooms = property.NumberOfBathrooms,
				NumberOfBedrooms = property.NumberOfBedrooms,
				Beds = property.Beds,
				Username = user != null ? $"{user.FirstName} {user.LastName}" : "N/A",
				UserImage = user?.Image,
				CityName = cityInfo.Name,
				CountryNmae = cityInfo.Country.Name
			};
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
