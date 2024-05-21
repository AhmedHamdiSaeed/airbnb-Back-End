using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class PropertyAmentity:BaseEntity<int>
	{
		[ForeignKey(nameof(Property))]
		public int PropertyId { get; set; }
		public Property Property { get; set; }
		[ForeignKey(nameof(AmentityId))]

		public int AmentityId { get; set; }
		public Amenity Amenity { get; set; }
	}
}
