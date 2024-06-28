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
		[ForeignKey(nameof(UserReview))]
		public string UserId { get; set; }
		public AppUser UserReview { get; set; }


		//[ForeignKey(nameof(Property))]
		//public int PropertyId { get; set; }
		//public Property Property { get; set; }

		  public int Rating { get; set; }
			public string Comment { get; set; } = string.Empty;
	}
	}
