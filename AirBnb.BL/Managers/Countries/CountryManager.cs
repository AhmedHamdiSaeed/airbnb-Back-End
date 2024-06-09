using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.CountryRepo;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Countries
{
	public class CountryManager : ICountryManager
	{
		private readonly IUnitOfWork _unitOfWork;
        public CountryManager(IUnitOfWork unitOfWork)
        {
         _unitOfWork=unitOfWork;
        }

		public async Task<bool> AddCountry(CountryAddDto addCountry)
		{
			Country newCountry = new Country()
			{
				Name= addCountry.Name,
			};
			await _unitOfWork.CountryRepository.AddAsync(newCountry);
			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<bool> DeleteCountry(int cpuntryId)
		{
			Country deleteCountry = await _unitOfWork.CountryRepository.GetByIdAsync(cpuntryId);
			if(deleteCountry == null)
			{
				return false;
			}
			_unitOfWork.CountryRepository.Delete(deleteCountry);
			return _unitOfWork.SaveChanges() > 0;
		}

		public async Task<IEnumerable<CountryGetDto>> GetAllCountry()
		{
			IEnumerable<Country> AllCountry =await _unitOfWork.CountryRepository.GetAllAsync();
			if (AllCountry == null)
				return null;
			var result = AllCountry.Select(x => new CountryGetDto
			{
				Id = x.Id,
				Name = x.Name,
			});
			return result;
		}

		public async Task<bool> UpdateCountry(int countryId, CountryUpdateDto updateCountry)
		{
			Country Result = await _unitOfWork.CountryRepository.GetByIdAsync(countryId);
			if (Result == null)
			{
				return false;
			}
			Result.Name = updateCountry.Name;
			_unitOfWork.CountryRepository.Update(Result);
			return _unitOfWork.SaveChanges() > 0;
		}
	}
}
