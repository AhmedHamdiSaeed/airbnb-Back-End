using AirBnb.BL.Dtos.CityDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Cities
{
	public class CityManager : ICityManager
	{
		public readonly IUnitOfWork _unitOfWork;
        public CityManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;	
        }
        public async Task<bool> addCity(CityAddDto cityDto)
		{
			City getAddCity = new City()
			{
				Name = cityDto.Name,
				CountryId = cityDto.CountryId,
			};
			await _unitOfWork.CityPrpository.AddAsync(getAddCity);
			return _unitOfWork.SaveChanges()>0;
		}

		public async Task<bool> DeleteCity(int cityId)
		{
			City result =await _unitOfWork.CityPrpository.GetByIdAsync(cityId);
            if (result is null)
            {
				return false;
            }
			_unitOfWork.CityPrpository.Delete(result);
			return _unitOfWork.SaveChanges()>0;
        }

		public async Task<IEnumerable<CityGetDto>> GetAllCities()
		{
			IEnumerable<City> getAllCities = await _unitOfWork.CityPrpository.GetAllAsync();
			var result = getAllCities.Select(x => new CityGetDto
			{
				Id = x.Id,
				Name = x.Name,
				CountryId = x.CountryId,
			});
			if (result is null)
				return null;
			return result;
		}

		public async Task<bool> UpdateCity(int cityId, CityUpdateDto city)
		{
			City updateCity = await _unitOfWork.CityPrpository.GetByIdAsync(cityId);
				;
			updateCity.Name = city.Name;
			updateCity.CountryId = city.CountryId;

			 _unitOfWork.CityPrpository.Update(updateCity);

			return _unitOfWork.SaveChanges() > 0;
		}
	}
}
