using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.AppointmentAvailableDtos
{
	public class appAvailbletGetDto
	{
		public int Id { get; set; }
		public int PropertyId { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public decimal PricePerNight { get; set; }
		public int TotalProice { get; set; }
		public bool IsAvailable { get; set; }
	}
	public class apptAvailbleUseInBookingDto
	{
		public int PropertyId { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public int PricePerNight { get; set; }
		public int TotalProice { get; set; }
		public bool IsAvailable { get; set; }
	}
	public class ApptAvailableAddDto
	{
		//[Required]
		//[Range(1, int.MaxValue)]
		public int PropertyId { get; set; }

		//[Required]
		public DateTime From { get; set; }
		public DateTime To { get; set; }

		//[Required]
		//[Range(0, double.MaxValue)]
		//[Column(TypeName = "decimal(10,2)")]
		public decimal PricePerNight { get; set; }

		//[Required]
		public int IsAvailable { get; set; }
	}

	public class ApptAvailableDto
	{
		public int Id { get; set; }
		
		public int PropertyId { get; set; }

		public DateTime From { get; set; }
		public DateTime To { get; set; }

		
		public decimal PricePerNight { get; set; }

		public bool IsAvailable { get; set; }
	}
	
	public class ApptAvailableUpdateDto
	{


		//public DateTime From { get; set; }
		//public DateTime To { get; set; }
		public bool IsAvailable { get; set; }
	}
}
