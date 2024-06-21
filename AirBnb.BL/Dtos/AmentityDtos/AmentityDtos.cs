using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.AmentityDtos
{
	
	public class AmenityDto
	{
		public int Id { get; set; }
		
		public string Name { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		
		public int propertyId { get; set; }
	}

	public class AmenityAddDto
	{

		public string Name { get; set; } = string.Empty;

	
		public string Description { get; set; } = string.Empty;

		
		public int propertyId { get; set; }
	}
}
