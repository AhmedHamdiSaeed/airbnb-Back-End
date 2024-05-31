using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.BookingManagers
{
	public class BookingManager: IBookingManager
	{
        private readonly IUnitOfWork _unitOfWork;
        public BookingManager(IUnitOfWork unitOfWork)
        {
			_unitOfWork=unitOfWork;

		}

		public async Task<bool> AddBooking(string userid, AmentityGetDto amentity)
		{
			Booking booking = new Booking();
			booking.PropertyId=amentity.PropertyId;
			booking.UserId=userid;
			booking.CheckInDate = amentity.From;
			booking.CheckOutDate=amentity.To;
			booking.TotalPrice = amentity.TotalProice;
			booking.BookingStatus = 0;

			await _unitOfWork.BookingRepository.AddAsync(booking);
			return _unitOfWork.SaveChanges()>0;
		}

		public async Task<IEnumerable<BookingGetAllDto>> GetAllBookingForProperty(int propertyid)
		{
			IEnumerable<Booking> allBooking =await _unitOfWork.BookingRepository.GetAllBookingForProperty(propertyid);
			if (allBooking is null)
			{
				return null;
			}
			var result = allBooking.Select(x => new BookingGetAllDto
			{
				Id = x.Id,
				CheckInDate = x.CheckInDate,
				CheckOutDate = x.CheckOutDate,
				TotalPrice = x.TotalPrice,
				BookingStatus = x.BookingStatus,
			}
			);
			return result;
		}

		public async Task<IEnumerable<BookingGetAllDto>> GetAllUserBooking(string userid)
		{
			IEnumerable<Booking> allBooking = await _unitOfWork.BookingRepository.GetAllUserBooking(userid);
			if (allBooking is null)
			{
				return null;
			}
			var result = allBooking.Select(x => new BookingGetAllDto
			{
				Id = x.Id,
				CheckInDate = x.CheckInDate,
				CheckOutDate = x.CheckOutDate,
				TotalPrice = x.TotalPrice,
				BookingStatus = x.BookingStatus,
			}
			);
			return result;
		}

		public async Task<BookingGetDetailsHostDto> GetPropertyBookingDetails(int propertyId)
		{
			Booking getbooking = await _unitOfWork.BookingRepository.GetPropertyBookingDetails(propertyId);
			if (getbooking is null)
			{
				return null;
			}
			BookingGetDetailsHostDto result = new BookingGetDetailsHostDto();
			result.Id = getbooking.Id;
			result.CheckInDate = getbooking.CheckInDate;
			result.CheckOutDate = getbooking.CheckOutDate;
			result.TotalPrice = getbooking.TotalPrice;
			result.PropertyName = getbooking.Property.Name;
			result.UserName = $"{getbooking.User.FirstName} {getbooking.User.LastName}";
			result.UserImage = getbooking.User.Image;
			result.UserPhone = getbooking.User.PhoneNumber;
			return result;
		}

		public async Task<BookingGetDetailsUserDtos> GetUserBookingetails(int bookingid)
		{
			Booking getbooking =await _unitOfWork.BookingRepository.GetUserBookingetails(bookingid);
			if (getbooking is null)
				return null;
			BookingGetDetailsUserDtos result = new BookingGetDetailsUserDtos();
			result.Id = getbooking.Id;
			result.CheckInDate= getbooking.CheckInDate;
			result.CheckOutDate= getbooking.CheckOutDate;
			result.TotalPrice= getbooking.TotalPrice;
			result.propertyId = getbooking.Property.Id;
			result.PropertyName = getbooking.Property.Name;
			return result;
		}

		public  async Task<bool> UpdateBooking(int bookingid, BookingUpdateDto booking)
		{
			Booking getbooking =await _unitOfWork.BookingRepository.GetByIdAsync(bookingid);

			if(getbooking is null) return false;
			if(getbooking.BookingStatus == Status.Canceled) return false;
			getbooking.BookingStatus = booking.BookingStatus;
			_unitOfWork.BookingRepository.UpdateBooking(getbooking);
			return _unitOfWork.SaveChanges()>0;
		}
	}
}
