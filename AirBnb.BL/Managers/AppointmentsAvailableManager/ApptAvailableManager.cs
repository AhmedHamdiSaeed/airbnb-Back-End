using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.AppointmentsAvailableManager
{
	public class ApptAvailableManager : IApptAvailableManager
	{
		private readonly IUnitOfWork _unitOfwork;
		public ApptAvailableManager(IUnitOfWork unitOfWork)
		{
			_unitOfwork = unitOfWork;
		}

		// Add an appointment availability
		public async Task<ApptAvailableDto> Add(ApptAvailableAddDto apptAvailableAddDto)
		{
			var apptAvailable = new AppointmentsAvailable
			{
				PropertyId = Convert.ToInt32(apptAvailableAddDto.PropertyId),
				From = Convert.ToDateTime(apptAvailableAddDto.From),
				To = Convert.ToDateTime(apptAvailableAddDto.To),
				PricePerNight = Convert.ToDecimal(apptAvailableAddDto.PricePerNight),
				IsAvailable =Convert.ToBoolean(apptAvailableAddDto.IsAvailable),
			};

			await _unitOfwork.ApptAvailableRepository.AddAsync(apptAvailable);
			_unitOfwork.SaveChanges();

			return new ApptAvailableDto
			{
				Id = apptAvailable.Id,
				PropertyId = apptAvailable.PropertyId,
				From = Convert.ToDateTime(apptAvailable.From),
				To = Convert.ToDateTime(apptAvailable.To),
				PricePerNight = Convert.ToDecimal(apptAvailable.PricePerNight),
				IsAvailable = Convert.ToBoolean(apptAvailableAddDto.IsAvailable)
			};

		}


		// Update an appointment availability
		public async Task<ApptAvailableDto> Update(int apptAvailableId, ApptAvailableAddDto apptAvailableAddDto)
		{
			var apptAvailble = await _unitOfwork.ApptAvailableRepository.GetByIdAsync(apptAvailableId);

			if (apptAvailble == null)
				return null;


			apptAvailble.PropertyId = apptAvailableAddDto.PropertyId;
			apptAvailble.From = Convert.ToDateTime(apptAvailableAddDto.From);
			apptAvailble.To = Convert.ToDateTime(apptAvailableAddDto.To);
			apptAvailble.PricePerNight =Convert.ToDecimal(apptAvailableAddDto.PricePerNight) ;
			apptAvailble.IsAvailable =Convert.ToBoolean(apptAvailableAddDto.IsAvailable) ;

			_unitOfwork.SaveChanges();

			return new ApptAvailableDto
			{
				Id = apptAvailble.Id,
				From = apptAvailble.From,
				To = apptAvailble.To,
				PricePerNight = apptAvailble.PricePerNight,
				IsAvailable = apptAvailble.IsAvailable
			};
		}

		public async Task<ApptAvailableUpdateDto> UpdateAvailabilityByPropertyIdAsync(int appAvailable, ApptAvailableUpdateDto apptAvailableAddDto)
		{
			var apptAvailble = await _unitOfwork.ApptAvailableRepository.GetByIdAsync(appAvailable);

			if (apptAvailble == null)
				return null;

			//apptAvailble.From = Convert.ToDateTime(apptAvailableAddDto.From);
			//apptAvailble.To = Convert.ToDateTime(apptAvailableAddDto.To);
			apptAvailble.IsAvailable = apptAvailableAddDto.IsAvailable;

			_unitOfwork.SaveChanges();

			return new ApptAvailableUpdateDto
			{

				//From = apptAvailble.From,
				//To = apptAvailble.To,
				IsAvailable = apptAvailble.IsAvailable
			};
		}

		// Delete an appoitment availability
		public async Task Delete(int apptAvailableId)
		{
			var apptAvailble = await _unitOfwork.ApptAvailableRepository.GetByIdAsync(apptAvailableId);

			if (apptAvailble == null)
			{
				throw new Exception($"Appointment Available with ID {apptAvailableId} not found.");
			}

			_unitOfwork.ApptAvailableRepository.Delete(apptAvailble);
			_unitOfwork.SaveChanges();

		}

		public async Task<IEnumerable<appAvailbletGetDto>> GetAllAppoinmentAvailable(int propId)
		{
			IEnumerable<AppointmentsAvailable> allAppoinment =await _unitOfwork.ApptAvailableRepository.GetAllAppoinmentAvailable(propId);
			var result = allAppoinment.Select(x => new appAvailbletGetDto
			{
				Id = x.Id,
				PropertyId = x.PropertyId,
				From = x.From,
				To = x.To,
				PricePerNight = x.PricePerNight,
				TotalProice= (int)(((TimeSpan)(x.To - x.From)).TotalDays) * ((int)x.PricePerNight),
				IsAvailable = x.IsAvailable

			});
			return result;
		}

		
	}
}
