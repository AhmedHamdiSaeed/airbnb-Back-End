using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.CategoryRepo;
using AirBnb.DAL.Repos.cityRepo;
using AirBnb.DAL.Repos.PropertyRepo;
using AirBnb.DAL.Repos.ReviewRepo;
using AirBnb.DAL.Repos.UserRepo;
using AirBnb.DAL.Unit;
using Microsoft.AspNetCore.Identity;
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
			service.AddDbContext<AppDbContext>(option=>option.UseSqlServer(connectionString));


			service.AddScoped<IReviewRepository, ReviewRepository>();
			service.AddScoped<IBookingRepository, BookingRepository>();
			service.AddScoped<IAmentityRepository, AmentityRepository>();
			service.AddScoped<IApptAvailableRepository, ApptAvailableRepository>();
			service.AddScoped<ICategoryRepository , CategoryRepository>();	
			service.AddScoped<ICityPrpository, CityPrpository>();	
			service.AddScoped<IPropertyRepository, PropertyRepository>();
			service.AddScoped<IUserRepository, UserRepository>();
			service.AddScoped<IUnitOfWork, UnitOfWork>();
			service.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

		}
	}
}
