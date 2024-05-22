using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.BookingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.BookingManagers
{
	public interface IBookingManager
	{
		Task<IEnumerable<BookingGetAllDto>> GetAllBookingForProperty(int propertyid);
		Task<BookingGetDetailsHostDto> GetPropertyBookingDetails(int propertyId);

		Task<bool> UpdateBooking(int bookingid, BookingUpdateDto booking);

		Task<IEnumerable<BookingGetAllDto>> GetAllUserBooking(string userid);
		Task<BookingGetDetailsUserDtos> GetUserBookingetails(int bookingid);
		Task<bool> AddBooking(string userid, AmentityGetDto amentity );
	}
}
