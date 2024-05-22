using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public enum Status
	{
		Pending=0,
		Confirmed = 1,
		Canceled = 2
	}
	public class Booking:BaseEntity<int>
	{

		[ForeignKey(nameof(Property))]
		public int PropertyId { get; set; }
		public Property Property { get; set; }

		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = string.Empty;
		public AppUser User {  get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set;}
		public int TotalPrice { get; set; }
		public Status BookingStatus { get; set; }
		
	}
}
