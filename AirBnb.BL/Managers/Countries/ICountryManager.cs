using AirBnb.BL.Dtos.CountryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Countries
{
	public interface ICountryManager
	{
		public Task<IEnumerable<CountryGetDto>> GetAllCountry();
		public Task<bool> AddCountry(CountryAddDto addCountry);
		public Task<bool> DeleteCountry(int cpuntryId);
		public Task<bool> UpdateCountry(int countryId, CountryUpdateDto updateCountry);

	}
}
	