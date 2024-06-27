using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.PaymentRepo
{
	public interface IPaymentRepository
	{
		Task<Booking> CreateOrUpdatePayment(int bookingId);
	}
}
