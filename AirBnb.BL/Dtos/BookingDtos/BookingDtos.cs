using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.BookingDtos
{
	public class BookingGetAllDto
	{
		public int Id { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public int TotalPrice { get; set; }
		public Status BookingStatus { get; set; }
		public int propertyId { get; set; }
		public string propImage {  get; set; }
		public string propTitle { get; set; }

	}
	public class BookingUpdateDto
	{
		public Status BookingStatus { get; set; }

	}
	public class BookingGetDetailsUserDtos
	{
		public int Id { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public int TotalPrice { get; set; }
		public int propertyId { get; set; }
		public string PropertyName { get; set; }

	}
	public class BookingGetDetailsHostDto
	{
		public int Id { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }

		public int TotalPrice { get; set; }
		public string PropertyName { get; set; }
		public string UserName { get; set; }
		public int UserAge { get; set; }
		public string UserImage {  get; set; }
		public string UserPhone { get; set; }
		public int Status { get; set; }
	}
	public class BookingAddDto
	{
		public int PropertyId { get; set; }

		public string UserId { get; set; } = string.Empty;
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public int TotalPrice { get; set; }
		public Status BookingStatus { get; set; } 
	}
	public class AvailabilityUpdateDto
	{
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public bool IsAvailable { get; set; }
	}
	public class BookingDataForPayment
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public int TotalPrice { get; set; }
		public string ClientSecret { get; set; }
		public string PaymentIntentId { get; set; }

	}
}
