using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CountryDtos
{
	public class CountryGetDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public class CountryAddDto
	{
		public string Name { get; set; }

	}
	public class CountryUpdateDto
	{
		public string Name { get; set; }

	}
}
