using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos
{
	public class GetPropertyDetailsDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public int Beds { get; set; }
		public string Username { get; set; }
		public string UserImage { get; set; } = string.Empty;
		public string CityName { get; set; }
		public string CountryNmae { get; set; }
		// public int MaximumNumberOfGuests { get; set; }


	}
}
