﻿using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.cityRepo
{
	public class CityPrpository :GenericRepository<City>, ICityPrpository
	{
		private readonly AppDbContext _context;
		public CityPrpository(AppDbContext context):base(context) 
		{
			_context = context;

		}

		public async Task<City> GetcountrywithCities(int cityId)
		{
			return await _context.Set<City>().Include(b => b.Country)
				.FirstOrDefaultAsync(p => p.Id == cityId);
		}
	}
}
