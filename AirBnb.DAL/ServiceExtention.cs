using AirBnb.DAL.Data.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL
{
	public static class ServiceExtention
	{
		public static void AddDALService(this IServiceCollection service, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("cs");
			service.AddDbContext<AppDbContext>(option => option.UseSqlServer(connectionString));
		}
	}
}
