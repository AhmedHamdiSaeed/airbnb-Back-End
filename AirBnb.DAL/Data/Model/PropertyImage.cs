using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class PropertyImage:BaseEntity<int>
	{
		[ForeignKey(nameof(Property))]
		public int PropertyId { get; set; }
		public Property Property { get; set; }
		public string ImageUrl { get; set; } = string.Empty;
		public bool IsMainImage { get; set; }
	}
}
