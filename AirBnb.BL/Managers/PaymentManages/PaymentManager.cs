using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Unit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.PaymentManages
{
	public class PaymentManager : IPaymentManager
	{
		private readonly IUnitOfWork _UnitOfWork;
		private readonly IConfiguration _config;

		public PaymentManager(IUnitOfWork UnitOfWork, IConfiguration config)
		{

			_UnitOfWork = UnitOfWork;
			_config = config;
		}
		public async Task<BookingDataForPayment> CreateOrUpdatePayment(int bookingId)
		{
			StripeConfiguration.ApiKey = _config["StripeSetting:Secretkey"];
			var booking = await _UnitOfWork.BookingRepository.getBookingByIdWithData(bookingId);

			var services = new PaymentIntentService();
			PaymentIntent intent;
			if (string.IsNullOrEmpty(booking.PaymentIntentId))
			{
				var options = new PaymentIntentCreateOptions
				{
					Amount = (long)(booking.TotalPrice * 100),
					Currency = "usd",
					PaymentMethodTypes = new List<string> { "card" }
				};
				intent = await services.CreateAsync(options);
				booking.PaymentIntentId = intent.Id;
				booking.ClientSecret = intent.ClientSecret;
			}
			else
			{
				var options = new PaymentIntentUpdateOptions
				{
					Amount = (long)(booking.TotalPrice * 100),
				};
				await services.UpdateAsync(booking.PaymentIntentId, options);
			}

			_UnitOfWork.BookingRepository.UpdateBooking(booking);
			var result = new BookingDataForPayment
			{
				Id = booking.Id,
				UserName = booking.User.FirstName + ' ' + booking.User.LastName,
				TotalPrice = booking.TotalPrice,
				ClientSecret = booking.ClientSecret,
				PaymentIntentId = booking.PaymentIntentId
			};
			return result;
		}

		public async Task<BookingDataForPayment> GetBookingForPayment(int bookingId)
		{
			var booking = await _UnitOfWork.BookingRepository.getBookingByIdWithData(bookingId);
			var result = new BookingDataForPayment
			{
				Id = booking.Id,
				UserName = booking.User.FirstName + ' ' + booking.User.LastName,
				TotalPrice = booking.TotalPrice,
				ClientSecret = booking.ClientSecret,
				PaymentIntentId = booking.PaymentIntentId
			};
			return result;
		}
	}
}
