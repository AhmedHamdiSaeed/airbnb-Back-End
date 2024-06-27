using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.PaymentManages
{
	public interface IPaymentManager
	{
		Task<BookingDataForPayment> CreateOrUpdatePayment(int bookingId);
		Task<BookingDataForPayment> GetBookingForPayment(int bookingId);

	}
}
