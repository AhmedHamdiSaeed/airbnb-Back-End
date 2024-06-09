using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyImagesDtos
{
	public class PropertyImagesGet
	{
		public int Id { get; set; }
		public int PropertyId { get; set; }
		public string ImageUrl { get; set; } = string.Empty;

	}
	public class PropertyImagesAddAndUpdate
	{
		public int PropertyId { get; set; }
		public string ImageUrl { get; set; } = string.Empty;
	}
}
