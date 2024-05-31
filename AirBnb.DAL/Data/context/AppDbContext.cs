using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AirBnb.DAL.Data.context
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{



		public DbSet<Amenity> Amenities { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countires { get; set; }
		public DbSet<Property> Properties { get; set; }

		public DbSet<PropertyImage> PropertyImages { get; set; }
		public DbSet<AppointmentsAvailable> AppointmentsAvailable { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Rule> Rules { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


			#region countries
			builder.Entity<Country>().HasData(
				new Country { Id = 1, Name = "Egypt" },
				new Country { Id = 2, Name = "France" },
				new Country { Id = 3, Name = "Italy" },
				new Country { Id = 4, Name = "Algeria" },
				new Country { Id = 5, Name = "Oman" },
				new Country { Id = 6, Name = "Yemen" },
				new Country { Id = 7, Name = "Germany" },
				new Country { Id = 8, Name = "Qatar" },
				new Country { Id = 9, Name = "Palestine" },
				new Country { Id = 10, Name = "Morocco" }

				);
			#endregion


			#region City
			builder.Entity<City>().HasData(
				new City { Id = 1, Name = "Cairo", CountryId = 1 },
				new City { Id = 2, Name = "Tokyo", CountryId = 2 },
				new City { Id = 3, Name = "London", CountryId = 3 },
				new City { Id = 4, Name = "Paris", CountryId = 4 },
				new City { Id = 5, Name = "New York City", CountryId = 5 },
				new City { Id = 6, Name = "Berlin", CountryId = 6 },
				new City { Id = 7, Name = "Rome", CountryId = 7 },
				new City { Id = 8, Name = "Madrid", CountryId = 8 },
				new City { Id = 9, Name = "Singapore", CountryId = 9 },
				new City { Id = 10, Name = "Seoul", CountryId = 10 },
				new City { Id = 11, Name = "Sydney", CountryId = 1 },
				new City { Id = 12, Name = "Buenos Aires", CountryId = 2 },
				new City { Id = 13, Name = "Toronto", CountryId = 3 },
				new City { Id = 14, Name = "Moscow", CountryId = 4 },
				new City { Id = 15, Name = "Dubai", CountryId = 5 },
				new City { Id = 16, Name = "São Paulo", CountryId = 6 },
				new City { Id = 17, Name = "Mexico City", CountryId = 7 },
				new City { Id = 18, Name = "Los Angeles", CountryId = 8 },
				new City { Id = 19, Name = "Mumbai", CountryId = 9 },
				new City { Id = 20, Name = "Istanbul", CountryId = 10 },
				new City { Id = 21, Name = "Beijing", CountryId = 1 }

				);
			#endregion

			#region category
			builder.Entity<Category>().HasData(
				new Category { Id = 21, Name = "Apartment",Description="Description For Category" },
				new Category { Id = 1, Name = "Entire Place", Description = "Guests have the entire home or apartment to themselves" },
				new Category { Id = 2, Name = "Private Room", Description = "Guests have a private room but share common areas with the host or other guests" },
				new Category { Id = 3, Name = "Shared Room", Description = "Guests share a room with the host or other guests" },
				new Category { Id = 4, Name = "Unique Stays", Description = "Unusual or unconventional accommodations (treehouses, yurts, etc.)" },
				new Category { Id = 5, Name = "Beachfront", Description = "Properties with direct access to a beach" },
				new Category { Id = 6, Name = "Ski-in/Ski-out", Description = "Properties with ski-in/ski-out access" },
				new Category { Id = 7, Name = "Pet-Friendly", Description = "Properties that allow pets" },
				new Category { Id = 8, Name = "Luxury", Description = "High-end properties with premium amenities" },
				new Category { Id = 9, Name = "Cabin", Description = "Rustic cabins for a cozy getaway" },
				new Category { Id = 10, Name = "Apartment", Description = "Modern apartments in urban settings" },
				new Category { Id = 11, Name = "Loft", Description = "Spacious lofts with open layouts" },
				new Category { Id = 12, Name = "Villa", Description = "Luxurious villas with private pools or jacuzzis" },
				new Category { Id = 13, Name = "Castle", Description = "Historic castles for a unique experience" },
				new Category { Id = 14, Name = "Treehouse", Description = "Treehouses for a whimsical stay" },
				new Category { Id = 15, Name = "Boat", Description = "Houseboats or other boats for a stay on the water" },
				new Category { Id = 16, Name = "Dome", Description = "Unique dome-shaped accommodations" },
				new Category { Id = 17, Name = "Boutique Hotel", Description = "Small, stylish hotels with personalized service" },
				new Category { Id = 18, Name = "Eco-Friendly", Description = "Properties committed to sustainable practices" },
				new Category { Id = 19, Name = "Family-Friendly", Description = "Properties with amenities for families with children" },
				new Category { Id = 20, Name = "Workcation-Friendly", Description = "Properties with features suitable for remote work (fast Wi-Fi, dedicated workspace)" }





		

				);
			#endregion

			#region Property
			builder.Entity<Property>().HasData(
				new Property { Id=1, Name="Apartment",Description="No Description", Adress="Cairo",NumberOfBathrooms=1,NumberOfBedrooms=4,Beds=8,UserId= "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f",CategoryId=1,CityId=1,Status=Status.Pending },
				new Property { Id = 2, Name = "Beach House", Description = "Sea view with modern amenities", Adress = "Alexandria", NumberOfBathrooms = 2, NumberOfBedrooms = 3, Beds = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 2, CityId = 2, Status = Status.Confirmed },
				new Property { Id = 3, Name = "Mountain Cabin", Description = "Cozy cabin in the mountains", Adress = "Aswan", NumberOfBathrooms = 1, NumberOfBedrooms = 2, Beds = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 3, CityId = 3, Status = Status.Pending },
				new Property { Id = 4, Name = "Luxury Villa", Description = "Luxurious villa with a private pool", Adress = "Sharm El-Sheikh", NumberOfBathrooms = 4, NumberOfBedrooms = 5, Beds = 10, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 4, CityId = 4, Status = Status.Canceled },
				new Property { Id = 5, Name = "Downtown Condo", Description = "Modern condo in the city center", Adress = "Giza", NumberOfBathrooms = 2, NumberOfBedrooms = 2, Beds = 4, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 5, CityId = 5, Status = Status.Pending },
				new Property { Id = 6, Name = "Farmhouse", Description = "Spacious farmhouse with a garden", Adress = "Luxor", NumberOfBathrooms = 3, NumberOfBedrooms = 4, Beds = 7, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 6, CityId = 6, Status = Status.Confirmed },
				new Property { Id = 7, Name = "Penthouse", Description = "Penthouse with panoramic views", Adress = "Cairo", NumberOfBathrooms = 3, NumberOfBedrooms = 3, Beds = 6, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 7, CityId = 1, Status = Status.Pending },
				new Property { Id = 8, Name = "Suburban Home", Description = "Family home in a quiet suburb", Adress = "Helwan", NumberOfBathrooms = 2, NumberOfBedrooms = 3, Beds = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 8, CityId = 8, Status = Status.Pending },
				new Property { Id = 9, Name = "Studio Apartment", Description = "Compact studio in a bustling area", Adress = "Alexandria", NumberOfBathrooms = 1, NumberOfBedrooms = 1, Beds = 1, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 9, CityId = 2, Status = Status.Canceled },
				new Property { Id = 10, Name = "Country Cottage", Description = "Charming cottage in the countryside", Adress = "Minya", NumberOfBathrooms = 1, NumberOfBedrooms = 2, Beds = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 10, CityId = 10, Status = Status.Pending },
				new Property { Id = 11, Name = "Lake House", Description = "Peaceful house by the lake", Adress = "Fayoum", NumberOfBathrooms = 2, NumberOfBedrooms = 3, Beds = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 11, CityId = 11, Status = Status.Pending },
				new Property { Id = 12, Name = "Urban Loft", Description = "Stylish loft in an urban setting", Adress = "Cairo", NumberOfBathrooms = 1, NumberOfBedrooms = 2, Beds = 2, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 12, CityId = 1, Status = 0 },
				new Property { Id = 13, Name = "Townhouse", Description = "Modern townhouse with a garage", Adress = "Suez", NumberOfBathrooms = 2, NumberOfBedrooms = 3, Beds = 4, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 13, CityId = 13, Status = Status.Pending },
				new Property { Id = 14, Name = "Historical Home", Description = "Home with historical significance", Adress = "Alexandria", NumberOfBathrooms = 3, NumberOfBedrooms = 4, Beds = 7, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 14, CityId = 2, Status = Status.Pending },
				new Property { Id = 15, Name = "Desert Retreat", Description = "Retreat in the quiet of the desert", Adress = "Siwa", NumberOfBathrooms = 1, NumberOfBedrooms = 2, Beds = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 15, CityId = 15, Status = Status.Confirmed },
				new Property { Id = 16, Name = "Bungalow", Description = "Single-story bungalow with a yard", Adress = "Dahab", NumberOfBathrooms = 1, NumberOfBedrooms = 3, Beds = 4, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 16, CityId = 16, Status = Status.Pending },
				new Property { Id = 17, Name = "Modern Flat", Description = "Modern flat in a residential complex", Adress = "Cairo", NumberOfBathrooms = 1, NumberOfBedrooms = 1, Beds = 1, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 17, CityId = 1, Status = Status.Pending },
				new Property { Id = 18, Name = "Eco-Friendly House", Description = "Eco-friendly house with solar panels", Adress = "Port Said", NumberOfBathrooms = 2, NumberOfBedrooms = 3, Beds = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 18, CityId = 18, Status = Status.Canceled },
				new Property { Id = 19, Name = "Seaside Villa", Description = "Villa with a view of the sea", Adress = "Hurghada", NumberOfBathrooms = 4, NumberOfBedrooms = 5, Beds = 9, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 19, CityId = 19, Status = Status.Pending },
				new Property { Id = 20, Name = "Rustic Cabin", Description = "Cabin with a rustic charm", Adress = "Sinai", NumberOfBathrooms = 1, NumberOfBedrooms = 2, Beds = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CategoryId = 20, CityId = 20, Status = Status.Confirmed }
			

				);
			#endregion


			#region PropertyImage
			builder.Entity<PropertyImage>().HasData(
				
				new PropertyImage { Id = 1, PropertyId = 1, ImageUrl = "https://example.com/image1.jpg", IsMainImage = true },
				new PropertyImage { Id = 2, PropertyId = 1, ImageUrl = "https://example.com/image2.jpg", IsMainImage = false },
				new PropertyImage { Id = 3, PropertyId = 1, ImageUrl = "https://example.com/image3.jpg", IsMainImage = false },
				new PropertyImage { Id = 4, PropertyId = 1, ImageUrl = "https://example.com/image4.jpg", IsMainImage = false },

				new PropertyImage { Id = 5, PropertyId = 2, ImageUrl = "https://example.com/image5.jpg", IsMainImage = true },
				new PropertyImage { Id = 6, PropertyId = 2, ImageUrl = "https://example.com/image6.jpg", IsMainImage = false },
				new PropertyImage { Id = 7, PropertyId = 2, ImageUrl = "https://example.com/image7.jpg", IsMainImage = false },
				new PropertyImage { Id = 8, PropertyId = 2, ImageUrl = "https://example.com/image8.jpg", IsMainImage = false },

				new PropertyImage { Id = 9, PropertyId = 3, ImageUrl = "https://example.com/image9.jpg", IsMainImage = true },
				new PropertyImage { Id = 10, PropertyId = 3, ImageUrl = "https://example.com/image10.jpg", IsMainImage = false },
				new PropertyImage { Id = 11, PropertyId = 3, ImageUrl = "https://example.com/image11.jpg", IsMainImage = false },
				new PropertyImage { Id = 12, PropertyId = 3, ImageUrl = "https://example.com/image12.jpg", IsMainImage = false },

				new PropertyImage { Id = 13, PropertyId = 4, ImageUrl = "https://example.com/image13.jpg", IsMainImage = true },
				new PropertyImage { Id = 14, PropertyId = 4, ImageUrl = "https://example.com/image14.jpg", IsMainImage = false },
				new PropertyImage { Id = 15, PropertyId = 4, ImageUrl = "https://example.com/image15.jpg", IsMainImage = false },
				new PropertyImage { Id = 16, PropertyId = 4, ImageUrl = "https://example.com/image16.jpg", IsMainImage = false },

				new PropertyImage { Id = 17, PropertyId = 5, ImageUrl = "https://example.com/image17.jpg", IsMainImage = true },
				new PropertyImage { Id = 18, PropertyId = 5, ImageUrl = "https://example.com/image18.jpg", IsMainImage = false },
				new PropertyImage { Id = 19, PropertyId = 5, ImageUrl = "https://example.com/image19.jpg", IsMainImage = false },
				new PropertyImage { Id = 20, PropertyId = 5, ImageUrl = "https://example.com/image20.jpg", IsMainImage = false },

				new PropertyImage { Id = 21, PropertyId = 6, ImageUrl = "https://example.com/image21.jpg", IsMainImage = true },
				new PropertyImage { Id = 22, PropertyId = 6, ImageUrl = "https://example.com/image22.jpg", IsMainImage = false },
				new PropertyImage { Id = 23, PropertyId = 6, ImageUrl = "https://example.com/image23.jpg", IsMainImage = false },
				new PropertyImage { Id = 24, PropertyId = 6, ImageUrl = "https://example.com/image24.jpg", IsMainImage = false },

				new PropertyImage { Id = 25, PropertyId = 7, ImageUrl = "https://example.com/image25.jpg", IsMainImage = true },
				new PropertyImage { Id = 26, PropertyId = 7, ImageUrl = "https://example.com/image26.jpg", IsMainImage = false },
				new PropertyImage { Id = 27, PropertyId = 7, ImageUrl = "https://example.com/image27.jpg", IsMainImage = false },
				new PropertyImage { Id = 28, PropertyId = 7, ImageUrl = "https://example.com/image28.jpg", IsMainImage = false },

				new PropertyImage { Id = 29, PropertyId = 8, ImageUrl = "https://example.com/image29.jpg", IsMainImage = true },
				new PropertyImage { Id = 30, PropertyId = 8, ImageUrl = "https://example.com/image30.jpg", IsMainImage = false },
				new PropertyImage { Id = 31, PropertyId = 8, ImageUrl = "https://example.com/image31.jpg", IsMainImage = false },
				new PropertyImage { Id = 32, PropertyId = 8, ImageUrl = "https://example.com/image32.jpg", IsMainImage = false },

				new PropertyImage { Id = 33, PropertyId = 9, ImageUrl = "https://example.com/image33.jpg", IsMainImage = true },
				new PropertyImage { Id = 34, PropertyId = 9, ImageUrl = "https://example.com/image34.jpg", IsMainImage = false },
				new PropertyImage { Id = 35, PropertyId = 9, ImageUrl = "https://example.com/image35.jpg", IsMainImage = false },
				new PropertyImage { Id = 36, PropertyId = 9, ImageUrl = "https://example.com/image36.jpg", IsMainImage = false },

				new PropertyImage { Id = 37, PropertyId = 10, ImageUrl = "https://example.com/image37.jpg", IsMainImage = true },
				new PropertyImage { Id = 38, PropertyId = 10, ImageUrl = "https://example.com/image38.jpg", IsMainImage = false },
				new PropertyImage { Id = 39, PropertyId = 10, ImageUrl = "https://example.com/image39.jpg", IsMainImage = false },
				new PropertyImage { Id = 40, PropertyId = 10, ImageUrl = "https://example.com/image40.jpg", IsMainImage = false },

				new PropertyImage { Id = 41, PropertyId = 11, ImageUrl = "https://example.com/image41.jpg", IsMainImage = true },
				new PropertyImage { Id = 42, PropertyId = 11, ImageUrl = "https://example.com/image42.jpg", IsMainImage = false },
				new PropertyImage { Id = 43, PropertyId = 11, ImageUrl = "https://example.com/image43.jpg", IsMainImage = false },
				new PropertyImage { Id = 44, PropertyId = 11, ImageUrl = "https://example.com/image44.jpg", IsMainImage = false },

				new PropertyImage { Id = 45, PropertyId = 12, ImageUrl = "https://example.com/image45.jpg", IsMainImage = true },
				new PropertyImage { Id = 46, PropertyId = 12, ImageUrl = "https://example.com/image46.jpg", IsMainImage = false },
				new PropertyImage { Id = 47, PropertyId = 12, ImageUrl = "https://example.com/image47.jpg", IsMainImage = false },
				new PropertyImage { Id = 48, PropertyId = 12, ImageUrl = "https://example.com/image48.jpg", IsMainImage = false },

				new PropertyImage { Id = 49, PropertyId = 13, ImageUrl = "https://example.com/image49.jpg", IsMainImage = true },
				new PropertyImage { Id = 50, PropertyId = 13, ImageUrl = "https://example.com/image50.jpg", IsMainImage = false },
				new PropertyImage { Id = 51, PropertyId = 13, ImageUrl = "https://example.com/image51.jpg", IsMainImage = false },
				new PropertyImage { Id = 52, PropertyId = 13, ImageUrl = "https://example.com/image52.jpg", IsMainImage = false },

				new PropertyImage { Id = 53, PropertyId = 14, ImageUrl = "https://example.com/image53.jpg", IsMainImage = true },
				new PropertyImage { Id = 54, PropertyId = 14, ImageUrl = "https://example.com/image54.jpg", IsMainImage = false },
				new PropertyImage { Id = 55, PropertyId = 14, ImageUrl = "https://example.com/image55.jpg", IsMainImage = false },
				new PropertyImage { Id = 56, PropertyId = 14, ImageUrl = "https://example.com/image56.jpg", IsMainImage = false },

				new PropertyImage { Id = 57, PropertyId = 15, ImageUrl = "https://example.com/image57.jpg", IsMainImage = true },
				new PropertyImage { Id = 58, PropertyId = 15, ImageUrl = "https://example.com/image58.jpg", IsMainImage = false },
				new PropertyImage { Id = 59, PropertyId = 15, ImageUrl = "https://example.com/image59.jpg", IsMainImage = false }

				);
			#endregion

			#region Amentity
			builder.Entity<Amenity>().HasData(
				new Amenity { Id = 21, Name = "Egypt" ,Description="No Description",propertyId=1},
				new Amenity { Id = 1, Name = "Swimming Pool", Description = "Large outdoor pool", propertyId = 1 },
				new Amenity { Id = 2, Name = "Gym", Description = "Fully equipped fitness center", propertyId = 2 },
				new Amenity { Id = 3, Name = "WiFi", Description = "High-speed wireless internet", propertyId = 3 },
				new Amenity { Id = 4, Name = "Parking", Description = "Secure parking area", propertyId = 4 },
				new Amenity { Id = 5, Name = "Air Conditioning", Description = "Central air conditioning system", propertyId = 5 },
				new Amenity { Id = 6, Name = "Heating", Description = "Central heating system", propertyId = 6 },
				new Amenity { Id = 7, Name = "Balcony", Description = "Private balcony with a view", propertyId = 7 },
				new Amenity { Id = 8, Name = "Pet Friendly", Description = "Allows pets", propertyId = 8 },
				new Amenity { Id = 9, Name = "Spa", Description = "Full-service spa", propertyId = 9 },
				new Amenity { Id = 10, Name = "Kitchen", Description = "Fully equipped kitchen", propertyId = 10 },
				new Amenity { Id = 11, Name = "Laundry", Description = "In-unit washer and dryer", propertyId = 11 },
				new Amenity { Id = 12, Name = "Elevator", Description = "Elevator access", propertyId = 12 },
				new Amenity { Id = 13, Name = "Fireplace", Description = "Wood-burning fireplace", propertyId = 13 },
				new Amenity { Id = 14, Name = "BBQ Area", Description = "Outdoor BBQ area", propertyId = 14 },
				new Amenity { Id = 15, Name = "Hot Tub", Description = "Private hot tub", propertyId = 15 },
				new Amenity { Id = 16, Name = "Sauna", Description = "Private sauna", propertyId = 16 },
				new Amenity { Id = 17, Name = "Garden", Description = "Private garden area", propertyId = 17 },
				new Amenity { Id = 18, Name = "Game Room", Description = "Room with games and entertainment", propertyId = 18 },
				new Amenity { Id = 19, Name = "Security", Description = "24-hour security", propertyId = 19 },
				new Amenity { Id = 20, Name = "Theater Room", Description = "Private home theater", propertyId = 20 }

				);
			#endregion


			#region countries
			builder.Entity<AppointmentsAvailable>().HasData(
				new AppointmentsAvailable { Id = 21, PropertyId = 1,From=DateTime.Now, To=DateTime.Now.AddDays(5),PricePerNight=20,IsAvailable=true },
				new AppointmentsAvailable { Id = 1, PropertyId = 1, From = DateTime.Now, To = DateTime.Now.AddDays(5), PricePerNight = 20, IsAvailable = true },
				new AppointmentsAvailable { Id = 2, PropertyId = 2, From = DateTime.Now.AddDays(1), To = DateTime.Now.AddDays(6), PricePerNight = 25, IsAvailable = true },
				new AppointmentsAvailable { Id = 3, PropertyId = 3, From = DateTime.Now.AddDays(2), To = DateTime.Now.AddDays(7), PricePerNight = 30, IsAvailable = false },
				new AppointmentsAvailable { Id = 4, PropertyId = 4, From = DateTime.Now.AddDays(3), To = DateTime.Now.AddDays(8), PricePerNight = 35, IsAvailable = true },
				new AppointmentsAvailable { Id = 5, PropertyId = 5, From = DateTime.Now.AddDays(4), To = DateTime.Now.AddDays(9), PricePerNight = 40, IsAvailable = true },
				new AppointmentsAvailable { Id = 6, PropertyId = 6, From = DateTime.Now.AddDays(5), To = DateTime.Now.AddDays(10), PricePerNight = 45, IsAvailable = false },
				new AppointmentsAvailable { Id = 7, PropertyId = 7, From = DateTime.Now.AddDays(6), To = DateTime.Now.AddDays(11), PricePerNight = 50, IsAvailable = true },
				new AppointmentsAvailable { Id = 8, PropertyId = 8, From = DateTime.Now.AddDays(7), To = DateTime.Now.AddDays(12), PricePerNight = 55, IsAvailable = true },
				new AppointmentsAvailable { Id = 9, PropertyId = 9, From = DateTime.Now.AddDays(8), To = DateTime.Now.AddDays(13), PricePerNight = 60, IsAvailable = false },
				new AppointmentsAvailable { Id = 10, PropertyId = 10, From = DateTime.Now.AddDays(9), To = DateTime.Now.AddDays(14), PricePerNight = 65, IsAvailable = true },
				new AppointmentsAvailable { Id = 11, PropertyId = 11, From = DateTime.Now.AddDays(10), To = DateTime.Now.AddDays(15), PricePerNight = 70, IsAvailable = true },
				new AppointmentsAvailable { Id = 12, PropertyId = 12, From = DateTime.Now.AddDays(11), To = DateTime.Now.AddDays(16), PricePerNight = 75, IsAvailable = false },
				new AppointmentsAvailable { Id = 13, PropertyId = 13, From = DateTime.Now.AddDays(12), To = DateTime.Now.AddDays(17), PricePerNight = 80, IsAvailable = true },
				new AppointmentsAvailable { Id = 14, PropertyId = 14, From = DateTime.Now.AddDays(13), To = DateTime.Now.AddDays(18), PricePerNight = 85, IsAvailable = true },
				new AppointmentsAvailable { Id = 15, PropertyId = 15, From = DateTime.Now.AddDays(14), To = DateTime.Now.AddDays(19), PricePerNight = 90, IsAvailable = false },
				new AppointmentsAvailable { Id = 16, PropertyId = 16, From = DateTime.Now.AddDays(15), To = DateTime.Now.AddDays(20), PricePerNight = 95, IsAvailable = true },
				new AppointmentsAvailable { Id = 17, PropertyId = 17, From = DateTime.Now.AddDays(16), To = DateTime.Now.AddDays(21), PricePerNight = 100, IsAvailable = true },
				new AppointmentsAvailable { Id = 18, PropertyId = 18, From = DateTime.Now.AddDays(17), To = DateTime.Now.AddDays(22), PricePerNight = 105, IsAvailable = false },
				new AppointmentsAvailable { Id = 19, PropertyId = 19, From = DateTime.Now.AddDays(18), To = DateTime.Now.AddDays(23), PricePerNight = 110, IsAvailable = true },
				new AppointmentsAvailable { Id = 20, PropertyId = 20, From = DateTime.Now.AddDays(19), To = DateTime.Now.AddDays(24), PricePerNight = 115, IsAvailable = true }

				);
			#endregion


			#region Booking
			builder.Entity<Booking>().HasData(
				new Booking { Id = 21, PropertyId = 1, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f",CheckInDate=DateTime.Now,CheckOutDate=DateTime.Now.AddDays(5),TotalPrice=100,BookingStatus=Status.Pending },
				new Booking { Id = 1, PropertyId = 1, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now, CheckOutDate = DateTime.Now.AddDays(5), TotalPrice = 100, BookingStatus = Status.Pending },
				new Booking { Id = 2, PropertyId = 2, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(1), CheckOutDate = DateTime.Now.AddDays(6), TotalPrice = 150, BookingStatus = Status.Confirmed },
				new Booking { Id = 3, PropertyId = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(2), CheckOutDate = DateTime.Now.AddDays(7), TotalPrice = 200, BookingStatus = Status.Confirmed },
				new Booking { Id = 4, PropertyId = 4, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(3), CheckOutDate = DateTime.Now.AddDays(8), TotalPrice = 250, BookingStatus = Status.Pending },
				new Booking { Id = 5, PropertyId = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(4), CheckOutDate = DateTime.Now.AddDays(9), TotalPrice = 300, BookingStatus = Status.Confirmed },
				new Booking { Id = 6, PropertyId = 6, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(5), CheckOutDate = DateTime.Now.AddDays(10), TotalPrice = 350, BookingStatus = Status.Confirmed },
				new Booking { Id = 7, PropertyId = 7, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(6), CheckOutDate = DateTime.Now.AddDays(11), TotalPrice = 400, BookingStatus = Status.Pending },
				new Booking { Id = 8, PropertyId = 8, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(7), CheckOutDate = DateTime.Now.AddDays(12), TotalPrice = 450, BookingStatus = Status.Confirmed },
				new Booking { Id = 9, PropertyId = 9, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(8), CheckOutDate = DateTime.Now.AddDays(13), TotalPrice = 500, BookingStatus = Status.Confirmed },
				new Booking { Id = 10, PropertyId = 10, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(9), CheckOutDate = DateTime.Now.AddDays(14), TotalPrice = 550, BookingStatus = Status.Pending },
				new Booking { Id = 11, PropertyId = 11, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(10), CheckOutDate = DateTime.Now.AddDays(15), TotalPrice = 600, BookingStatus = Status.Confirmed },
				new Booking { Id = 12, PropertyId = 12, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(11), CheckOutDate = DateTime.Now.AddDays(16), TotalPrice = 650, BookingStatus = Status.Confirmed },
				new Booking { Id = 13, PropertyId = 13, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(12), CheckOutDate = DateTime.Now.AddDays(17), TotalPrice = 700, BookingStatus = Status.Pending },
				new Booking { Id = 14, PropertyId = 14, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(13), CheckOutDate = DateTime.Now.AddDays(18), TotalPrice = 750, BookingStatus = Status.Confirmed },
				new Booking { Id = 15, PropertyId = 15, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(14), CheckOutDate = DateTime.Now.AddDays(19), TotalPrice = 800, BookingStatus = Status.Confirmed },
				new Booking { Id = 16, PropertyId = 16, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(15), CheckOutDate = DateTime.Now.AddDays(20), TotalPrice = 850, BookingStatus = Status.Pending },
				new Booking { Id = 17, PropertyId = 17, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(16), CheckOutDate = DateTime.Now.AddDays(21), TotalPrice = 900, BookingStatus = Status.Confirmed },
				new Booking { Id = 18, PropertyId = 18, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(17), CheckOutDate = DateTime.Now.AddDays(22), TotalPrice = 950, BookingStatus = Status.Confirmed },
				new Booking { Id = 19, PropertyId = 19, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(18), CheckOutDate = DateTime.Now.AddDays(23), TotalPrice = 1000, BookingStatus = Status.Pending },
				new Booking { Id = 20, PropertyId = 20, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", CheckInDate = DateTime.Now.AddDays(19), CheckOutDate = DateTime.Now.AddDays(24), TotalPrice = 1050, BookingStatus = Status.Confirmed }

				);
			#endregion

			#region Review
			builder.Entity<Review>().HasData(
				new Review { Id=1,BookingId=1, UserId= "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f",Rating=5, Comment="Good Comment" },
				new Review { Id = 2, BookingId = 2, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 4, Comment = "Nice place" },
				new Review { Id = 3, BookingId = 3, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 3, Comment = "Average experience" },
				new Review { Id = 4, BookingId = 4, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 2, Comment = "Not as expected" },
				new Review { Id = 5, BookingId = 5, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 5, Comment = "Excellent service" },
				new Review { Id = 6, BookingId = 6, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 4, Comment = "Good value for money" },
				new Review { Id = 7, BookingId = 7, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 3, Comment = "Decent stay" },
				new Review { Id = 8, BookingId = 8, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 1, Comment = "Terrible experience" },
				new Review { Id = 9, BookingId = 9, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 5, Comment = "Highly recommend" },
				new Review { Id = 10, BookingId = 10, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 4, Comment = "Very comfortable" },
				new Review { Id = 11, BookingId = 11, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 2, Comment = "Could be better" },
				new Review { Id = 12, BookingId = 12, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 5, Comment = "Loved the place" },
				new Review { Id = 13, BookingId = 13, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 3, Comment = "It was okay" },
				new Review { Id = 14, BookingId = 14, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 4, Comment = "Pretty good" },
				new Review { Id = 15, BookingId = 15, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 2, Comment = "Needs improvement" },
				new Review { Id = 16, BookingId = 16, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 5, Comment = "Fantastic stay" },
				new Review { Id = 17, BookingId = 17, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 1, Comment = "Very disappointing" },
				new Review { Id = 18, BookingId = 18, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 4, Comment = "Good location" },
				new Review { Id = 19, BookingId = 19, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 3, Comment = "Not bad" },
				new Review { Id = 20, BookingId = 20, UserId = "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f", Rating = 5, Comment = "Amazing experience" }
				);
			#endregion
			#region Rule
			builder.Entity<Rule>().HasData(
				new Rule { Id = 1, CheckIn= new TimeOnly(16, 0), CheckOut= new TimeOnly(9, 0), NumberOfGuest=2,Pets=true, TakePhotos=true, PropertyId=1 },
				new Rule { Id = 21, CheckIn = new TimeOnly(16, 0), CheckOut = new TimeOnly(9, 0), NumberOfGuest = 2, Pets = true, TakePhotos = true, PropertyId = 1 },
				new Rule { Id = 2, CheckIn = new TimeOnly(15, 0), CheckOut = new TimeOnly(10, 0), NumberOfGuest = 3, Pets = false, TakePhotos = true, PropertyId = 2 },
				new Rule { Id = 3, CheckIn = new TimeOnly(17, 0), CheckOut = new TimeOnly(11, 0), NumberOfGuest = 4, Pets = true, TakePhotos = false, PropertyId = 3 },
				new Rule { Id = 4, CheckIn = new TimeOnly(14, 0), CheckOut = new TimeOnly(12, 0), NumberOfGuest = 5, Pets = false, TakePhotos = true, PropertyId = 4 },
				new Rule { Id = 5, CheckIn = new TimeOnly(18, 0), CheckOut = new TimeOnly(9, 30), NumberOfGuest = 2, Pets = true, TakePhotos = true, PropertyId = 5 },
				new Rule { Id = 6, CheckIn = new TimeOnly(13, 0), CheckOut = new TimeOnly(10, 30), NumberOfGuest = 3, Pets = true, TakePhotos = false, PropertyId = 6 },
				new Rule { Id = 7, CheckIn = new TimeOnly(16, 30), CheckOut = new TimeOnly(8, 0), NumberOfGuest = 1, Pets = false, TakePhotos = true, PropertyId = 7 },
				new Rule { Id = 8, CheckIn = new TimeOnly(15, 30), CheckOut = new TimeOnly(11, 0), NumberOfGuest = 2, Pets = true, TakePhotos = true, PropertyId = 8 },
				new Rule { Id = 9, CheckIn = new TimeOnly(14, 30), CheckOut = new TimeOnly(12, 30), NumberOfGuest = 4, Pets = false, TakePhotos = false, PropertyId = 9 },
				new Rule { Id = 10, CheckIn = new TimeOnly(17, 30), CheckOut = new TimeOnly(10, 0), NumberOfGuest = 5, Pets = true, TakePhotos = true, PropertyId = 10 },
				new Rule { Id = 11, CheckIn = new TimeOnly(18, 0), CheckOut = new TimeOnly(9, 0), NumberOfGuest = 3, Pets = false, TakePhotos = true, PropertyId = 11 },
				new Rule { Id = 12, CheckIn = new TimeOnly(15, 0), CheckOut = new TimeOnly(8, 30), NumberOfGuest = 1, Pets = true, TakePhotos = false, PropertyId = 12 },
				new Rule { Id = 13, CheckIn = new TimeOnly(16, 30), CheckOut = new TimeOnly(11, 30), NumberOfGuest = 2, Pets = true, TakePhotos = true, PropertyId = 13 },
				new Rule { Id = 14, CheckIn = new TimeOnly(17, 0), CheckOut = new TimeOnly(12, 0), NumberOfGuest = 4, Pets = false, TakePhotos = true, PropertyId = 14 },
				new Rule { Id = 15, CheckIn = new TimeOnly(14, 0), CheckOut = new TimeOnly(10, 0), NumberOfGuest = 5, Pets = true, TakePhotos = false, PropertyId = 15 },
				new Rule { Id = 16, CheckIn = new TimeOnly(13, 0), CheckOut = new TimeOnly(9, 30), NumberOfGuest = 2, Pets = false, TakePhotos = true, PropertyId = 16 },
				new Rule { Id = 17, CheckIn = new TimeOnly(16, 0), CheckOut = new TimeOnly(8, 0), NumberOfGuest = 3, Pets = true, TakePhotos = true, PropertyId = 17 },
				new Rule { Id = 18, CheckIn = new TimeOnly(15, 0), CheckOut = new TimeOnly(11, 0), NumberOfGuest = 1, Pets = true, TakePhotos = false, PropertyId = 18 },
				new Rule { Id = 19, CheckIn = new TimeOnly(17, 0), CheckOut = new TimeOnly(9, 30), NumberOfGuest = 2, Pets = false, TakePhotos = true, PropertyId = 19 },
				new Rule { Id = 20, CheckIn = new TimeOnly(14, 0), CheckOut = new TimeOnly(10, 0), NumberOfGuest = 4, Pets = true, TakePhotos = true, PropertyId = 20 }
				);
			#endregion

		}
	}
}
