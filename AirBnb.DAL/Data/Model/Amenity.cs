using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class Amenity:BaseEntity<int>
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
