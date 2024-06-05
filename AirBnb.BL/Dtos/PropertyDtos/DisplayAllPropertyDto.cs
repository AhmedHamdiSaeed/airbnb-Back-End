using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos
{
	public class DisplayAllPropertyDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;

		public string City { get; set; }
	}
}
