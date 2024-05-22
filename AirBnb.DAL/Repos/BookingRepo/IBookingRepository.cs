using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.BookingRepo
{
	public interface IBookingRepository:IGenericRepository<Booking>
	{
		void UpdateBooking(Booking booking);
		//Hoster
		Task<IEnumerable<Booking>> GetAllBookingForProperty(int propertyId);
		Task<Booking> GetPropertyBookingDetails(int propertyId);
		


		//Guest
		Task<IEnumerable<Booking>> GetAllUserBooking(string userid);
		Task<Booking> GetUserBookingetails(int bookingid);
		
	}
}
