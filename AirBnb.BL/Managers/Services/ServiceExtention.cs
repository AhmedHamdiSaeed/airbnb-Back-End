﻿using AirBnb.BL.Managers.Amenities;
using AirBnb.BL.Managers.AppointmentsAvailableManager;
using AirBnb.BL.Managers.BookingManagers;
using AirBnb.BL.Managers.Categories;
using AirBnb.BL.Managers.Cities;
using AirBnb.BL.Managers.Countries;
using AirBnb.BL.Managers.Properties;
using AirBnb.BL.Managers.PropertiesImages;
using AirBnb.BL.Managers.Reviews;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Services
{
    public static class ServiceExtention
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<IReviewManager, ReviewManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IAmenityManager, AmenityManager>();
            services.AddScoped<IApptAvailableManager, ApptAvailableManager>();
            services.AddScoped<IPropertyManager, PropertyManager>();
            services.AddScoped<ICityManager, CityManager>();
            services.AddScoped<ICountryManager, CountryManager>();
            services.AddScoped<IPropertyImagesManager, PropertyImagesManager>();
        }
    }
}
