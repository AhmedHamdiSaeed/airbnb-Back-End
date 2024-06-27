using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.BookingRepo;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PaymentRepo
{
	public class PaymentRepository : IPaymentRepository
	{
		private readonly IBookingRepository _bookingRepository;
		private readonly IConfiguration _config;

		public PaymentRepository(IBookingRepository bookingRepository, IConfiguration config)
        {
			
			_bookingRepository = bookingRepository;
			_config = config;
		}
        public async Task<Booking> CreateOrUpdatePayment(int bookingId)
		{
			StripeConfiguration.ApiKey = _config["StripeSetting:Publishablekey"];
			var booking =await _bookingRepository.GetByIdAsync(bookingId);


			var services = new PaymentIntentService();
			PaymentIntent intent;
            if (string.IsNullOrEmpty(booking.PaymentIntentId))
            {
				var options = new PaymentIntentCreateOptions
				{
					Amount = booking.TotalPrice,
					Currency = "usd",
					PaymentMethodTypes = new List<string> { "card" }
				};
				intent = await services .CreateAsync(options);
				booking.PaymentIntentId = intent.Id;
				 booking.ClientSecret = intent.ClientSecret;
            }
			else
			{
				var options = new PaymentIntentUpdateOptions
				{

					Amount = booking.TotalPrice,
					
				};
				await services.UpdateAsync(booking.PaymentIntentId, options);
			}

			 _bookingRepository.UpdateBooking(booking);
			return booking;
		}
	}
}
