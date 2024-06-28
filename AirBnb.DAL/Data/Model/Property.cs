using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnb.DAL.Data.Model
{
	public class Property:BaseEntity<int>
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		//public decimal PricePerNight { get; set; }
		public int NumberOfBedrooms { get; set; }		
		public int NumberOfBathrooms { get; set; }
		public string DisplayedImage { get; set; }
		public int Beds { get; set; }

		[ForeignKey(nameof(User))]
		public string UserId { get; set; }
		public AppUser User { get; set; }

		[ForeignKey(nameof(Category))]

		public int CategoryId { get; set; }
		public Category Category { get; set; }
		[ForeignKey(nameof(City))]
		public int CityId { get; set; }
		public City City { get; set; }
		public Status Status { get; set; }

		public TimeOnly CheckIn { get; set; }
		public TimeOnly CheckOut { get; set; }
		public int NumberOfGuest { get; set; }
		public bool Pets { get; set; }
		public bool TakePhotos { get; set; }
		public IEnumerable<Amenity> Amenity { get; set; } = new HashSet<Amenity>();
		public IEnumerable<PropertyImage> PropertyImages { get; set; } = new HashSet<PropertyImage>();
		public IEnumerable<Booking> PropertyBokking { get; set; } = new HashSet<Booking>();
		public IEnumerable<AppointmentsAvailable> AppointmentsAvailable { get; set; } = new HashSet<AppointmentsAvailable>();
        //public IEnumerable<Review> Reviews { get; set; }

        //public int NumberOfReview
        //{
        //    get { return Reviews?.Count() ?? 0; }
        //}
        //[Range(0, 5)]
        //public double OverALLReview
        //{
        //    get
        //    {
        //        if (Reviews?.Count() > 0)
        //        {
        //            return Reviews.Average(review => review.Rating);
        //        }
        //        else
        //        {
        //            return 0.0;
        //        }
        //    }
        //}
    }
}