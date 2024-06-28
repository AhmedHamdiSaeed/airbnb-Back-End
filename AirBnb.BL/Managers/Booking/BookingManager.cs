using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.AppointmentAvailableDtos;
using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AirBnb.BL.Managers.BookingManagers
{
	public class BookingManager: IBookingManager
	{
        private readonly IUnitOfWork _unitOfWork;
        public BookingManager(IUnitOfWork unitOfWork)
        {
			_unitOfWork=unitOfWork;

		}

		public async Task<bool> AddBooking(string userid, appAvailbletGetDto amentity)
		{
			var booking = new Booking
			{
				PropertyId = amentity.PropertyId,
				UserId = userid,
				CheckInDate = Convert.ToDateTime(amentity.From),
				CheckOutDate = Convert.ToDateTime(amentity.To),
				TotalPrice = amentity.TotalProice,
				BookingStatus = Status.Pending,
			};


			await _unitOfWork.BookingRepository.AddAsync(booking);
			return _unitOfWork.SaveChanges()>0;
		}

		//public async Task<bool> AddBooking(string userid, BookingAddDto bookingAddDto)
		//{
		//	var booking = new Booking
		//	{
		//		PropertyId = bookingAddDto.PropertyId,
		//		UserId = userid,
		//		CheckInDate = bookingAddDto.CheckInDate,
		//		CheckOutDate = bookingAddDto.CheckOutDate,
		//		TotalPrice = bookingAddDto.TotalPrice,
		//		BookingStatus = Status.Pending,
		//		BookingStatus = bookingAdd Dto.BookingStatus,
		//	};

		//	await _unitOfWork.BookingRepository.AddAsync(booking);
		//	return _unitOfWork.SaveChanges() > 0;
		//}


		public async Task<int?> AdddBooking(string userId, BookingAddDto bookingAddDto)
		{
			var booking = new Booking
			{
				// Initialize properties
				UserId = userId,
				PropertyId = bookingAddDto.PropertyId,
				CheckInDate = bookingAddDto.CheckInDate,
				CheckOutDate = bookingAddDto.CheckOutDate,
				TotalPrice = bookingAddDto.TotalPrice,
				BookingStatus = Status.Pending,

			};

			await _unitOfWork.BookingRepository.AddAsync(booking);
			var result = _unitOfWork.SaveChanges() ;

			if (result > 0)
			{
				return booking.Id;
			}
			return null;
		}

		public async Task<bool> DeleteBookingAsync(int bookingId)
		{
			var booking = await _unitOfWork.BookingRepository.GetUserBookingetail(bookingId);
			if (booking == null)
			{
				return false;
			}

			_unitOfWork.BookingRepository.Delete(booking);
			_unitOfWork.SaveChanges();
			return true;
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
				propertyId=x.PropertyId,
				CheckInDate = x.CheckInDate,
				CheckOutDate = x.CheckOutDate,
				TotalPrice = x.TotalPrice,
				propImage=x.Property.DisplayedImage,
				propTitle=x.Property.Name,
				BookingStatus = x.BookingStatus,
			}
			);
			return result;
		}
		

		public async Task<IEnumerable<BookingGetDetailsHostDto>> GetPropertyBookingDetails(int propertyId)
		{
			IEnumerable<Booking> getbooking = await _unitOfWork.BookingRepository.GetPropertyBookingDetails(propertyId);
			if (getbooking is null)
			{
				return null;
			}
			var result = getbooking.Select(x => new BookingGetDetailsHostDto
			{
				Id = x.Id,
				CheckInDate = x.CheckInDate,
				CheckOutDate = x.CheckOutDate,
				TotalPrice = x.TotalPrice,
				PropertyName = x.Property.Name,
				UserName = $"{x.User.FirstName} {x.User.LastName}",
				UserImage = x.User.Image,
				UserPhone = x.User.PhoneNumber,
				Status =(int) x.BookingStatus
			}); ;
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
