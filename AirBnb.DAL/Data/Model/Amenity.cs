using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class Amenity:BaseEntity<int>
	{

		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public int propertyId { get; set; }
		

	}
}
