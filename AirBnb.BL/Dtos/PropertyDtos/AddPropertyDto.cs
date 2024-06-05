using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos
{
	public class AddPropertyDto
	{
		public string Name { get; set; } = string.Empty;
		public string UserId { get; set; } = string.Empty;

		//public int MaxNumberOfGuests { get; set; }
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public int Beds { get; set; }
		//public int PricePerNight { get; set; }
		public int CategoryId { get; set; }
		public int CityId { get; set; }
		public string Adress { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public Status Status { get; set; }
		public List<TimeIntervalDto> AppointmentsAvailable { get; set; }
	}
	public class TimeIntervalDto
	{
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public decimal PricePerNight { get; set; }
	}
}
