using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class Review:BaseEntity<int>
	{
		[ForeignKey(nameof(Booking))]
		public int BookingId { get; set; }
		public Booking Booking { get; set; }
		[ForeignKey(nameof(User))]
		public string UserId { get; set; }
		public AppUser User { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; } = string.Empty;
	}
}
