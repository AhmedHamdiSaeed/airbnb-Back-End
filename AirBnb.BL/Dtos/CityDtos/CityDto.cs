using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CityDtos
{
	public class CityGetDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int  CountryId { get; set; }
	}
	public class CityAddDto
	{
		public string Name { get; set; }
		public int CountryId { get; set; }
	}
	public class CityUpdateDto
	{
		public string Name { get; set; }
		public int CountryId { get; set; }
	}
	
}
