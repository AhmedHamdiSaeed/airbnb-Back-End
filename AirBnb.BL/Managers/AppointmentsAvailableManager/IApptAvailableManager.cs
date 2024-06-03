using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.AppointmentsAvailableManager
{
	public interface IApptAvailableManager
	{
		Task<ApptAvailableDto> Add(ApptAvailableAddDto appAvailableAddDto);
		Task<ApptAvailableDto> Update(int apptAvailableId, ApptAvailableAddDto apptAvailableAddDto);
		Task Delete(int apptAvailableId);
	}
}
