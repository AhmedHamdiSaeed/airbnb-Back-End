﻿using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
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
		Task<bool> AddBooking(string userid, BookingAddDto bookingAddDto);
        //Task<IEnumerable<AppointmentsAvailable>> GetPropertyAvailabilityAsync(int propertyId);
        //Task<bool> UpdateAvailabilityAsync(int propertyId, List<AvailabilityUpdateDto> availabilityUpdates);

    }
}
