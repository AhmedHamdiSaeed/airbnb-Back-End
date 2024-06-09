using AirBnb.BL.Dtos.CityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Cities
{
	public interface ICityManager
	{
		public Task<IEnumerable<CityGetDto>> GetAllCities();
		public Task<bool> addCity(CityAddDto city);
		public Task<bool> UpdateCity(int cityId,CityUpdateDto city);
		public Task<bool> DeleteCity(int cityId);
	}
}
