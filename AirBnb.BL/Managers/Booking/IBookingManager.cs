using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
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
		Task<IEnumerable<BookingGetDetailsHostDto>> GetPropertyBookingDetails(int propertyId);

		Task<bool> UpdateBooking(int bookingid, BookingUpdateDto booking);

		Task<IEnumerable<BookingGetAllDto>> GetAllUserBooking(string userid);
		Task<BookingGetDetailsUserDtos> GetUserBookingetails(int bookingid);
		Task<int?> AdddBooking(string userId, BookingAddDto bookingAddDto);
		Task<bool> DeleteBookingAsync(int bookingId);
		Task<bool> AddBooking(string userid, appAvailbletGetDto amentity);
	}
}
