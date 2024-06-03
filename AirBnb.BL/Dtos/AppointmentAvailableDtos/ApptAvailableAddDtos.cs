using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.AppointmentAvailableDtos
{
	public class ApptAvailableAddDto
	{
		[Required]
		[Range(1, int.MaxValue)]
		public int PropertyId { get; set; }

		[Required]
		public DateTime From { get; set; }
		public DateTime To { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		[Column(TypeName = "decimal(10,2)")]
		public decimal PricePerNight { get; set; }

		[Required]
		public bool IsAvailable { get; set; }
	}

	public class ApptAvailableDto
	{
		public int Id { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int PropertyId { get; set; }

		[Required]
		public DateTime From { get; set; }
		public DateTime To { get; set; }

		[Required]
		[Column(TypeName = "decimal(10,2)")]
		[Range(0, double.MaxValue)]
		public decimal PricePerNight { get; set; }

		[Required]
		public bool IsAvailable { get; set; }
	}
}
