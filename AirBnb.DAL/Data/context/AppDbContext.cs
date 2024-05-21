using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.context
{
	public class AppDbContext:IdentityDbContext<AppUser>
	{
		public DbSet<Amenity> Amenities { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countires { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<PropertyAmentity> PropertyAmentities { get; set; }
		public DbSet<PropertyImage> PropertyImages { get; set; }
		public DbSet<PropertyRule> PropertyRules { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Rule> Rules { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			
		}
	}
}
