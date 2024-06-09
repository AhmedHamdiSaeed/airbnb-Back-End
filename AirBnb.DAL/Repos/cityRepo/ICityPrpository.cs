using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.cityRepo
{
	public interface ICityPrpository:IGenericRepository<City>
	{
		Task<City> GetcountrywithCities(int cityId);
	}
}
