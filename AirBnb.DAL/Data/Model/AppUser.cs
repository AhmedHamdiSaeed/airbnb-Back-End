﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public enum Role
	{
		Guest=0,
		Host=0
	}
	public class AppUser:IdentityUser
	{
		public string DisplayName { get; set; } = string.Empty;
		public string Image {  get; set; }=string.Empty;
		public int Age { get; set; }
		public Role Role { get; set; }
		public IEnumerable<Review> UserReviews { get; set; } = new HashSet<Review>();
		public IEnumerable<Booking> UserBooking { get; set; } = new HashSet<Booking>();
		public IEnumerable<Property> UserProperties { get; set; } = new HashSet<Property>();

	}
}
