using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.BL.Managers.PaymentManages;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.Paument
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
        private readonly IPaymentManager _paymentManager;
        public PaymentController(IPaymentManager paymentManager)
        {
            _paymentManager = paymentManager;
        }


		//
		[HttpPost("Payment/{id}")]
		public async Task<ActionResult<BookingDataForPayment>> CreateOrUpdatePaymentIntent(int id)
		{
			return await _paymentManager.CreateOrUpdatePayment(id);
		}

		[HttpGet("getBookingForPayment/{id}")]
		public async Task<ActionResult<BookingDataForPayment>> GetBookingForPayment(int id)
		{
			return await _paymentManager.GetBookingForPayment(id);
		}

	}
}
