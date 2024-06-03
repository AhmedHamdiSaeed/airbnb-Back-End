using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.AmentityDtos
{
	public class AmentityGetDto
	{
		public int Id { get; set; }
		public int PropertyId { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public int PricePerNight { get; set; }
		public int TotalProice { get; set; }
		public bool IsAvailable { get; set; }
	}

	public class AmenityDto
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[MaxLength(250)]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Range(1, int.MaxValue)]
		public int propertyId { get; set; }
	}

	public class AmenityAddDto
	{
		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[MaxLength(250)]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Range(1, int.MaxValue)]
		public int propertyId { get; set; }
	}
}
