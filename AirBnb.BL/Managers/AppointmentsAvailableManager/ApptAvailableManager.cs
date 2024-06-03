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
				PropertyId = apptAvailableAddDto.PropertyId,
				From = apptAvailableAddDto.From,
				To = apptAvailableAddDto.To,
				PricePerNight = apptAvailableAddDto.PricePerNight,
				IsAvailable = apptAvailableAddDto.IsAvailable
			};

			await _unitOfwork.ApptAvailableRepository.AddAsync(apptAvailable);
			_unitOfwork.SaveChanges();

			return new ApptAvailableDto
			{
				Id = apptAvailable.Id,
				PropertyId = apptAvailable.PropertyId,
				From = apptAvailable.From,
				To = apptAvailable.To,
				PricePerNight = apptAvailable.PricePerNight,
				IsAvailable = apptAvailable.IsAvailable
			};

		}


		// Update an appointment availability
		public async Task<ApptAvailableDto> Update(int apptAvailableId, ApptAvailableAddDto apptAvailableAddDto)
		{
			var apptAvailble = await _unitOfwork.ApptAvailableRepository.GetByIdAsync(apptAvailableId);

			if (apptAvailble == null)
				return null;


			apptAvailble.PropertyId = apptAvailableAddDto.PropertyId;
			apptAvailble.From = apptAvailableAddDto.From;
			apptAvailble.To = apptAvailableAddDto.To;
			apptAvailble.PricePerNight = apptAvailableAddDto.PricePerNight;
			apptAvailble.IsAvailable = apptAvailableAddDto.IsAvailable;

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

	}
}
