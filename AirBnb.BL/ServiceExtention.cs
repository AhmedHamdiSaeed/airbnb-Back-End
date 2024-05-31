﻿using AirBnb.BL.Managers.BookingManagers;
using AirBnb.BL.Managers.Reviews;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL
{
	public static class ServiceExtention
	{
		public static void AddBLServices(this IServiceCollection services)
		{
			services.AddScoped<IBookingManager, BookingManager>();
			services.AddScoped<IReviewManager, ReviewManager>();
		}
	}
}
