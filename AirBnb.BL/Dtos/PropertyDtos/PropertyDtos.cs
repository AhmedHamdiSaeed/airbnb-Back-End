using AirBnb.BL.Dtos.PropertyImagesDtos;
using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.PropertyDtos
{
	public class PropertyGetDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string DisplayedImage { get; set; }
		public string Description { get; set; } 

	}
	public class PropAppoinmentAvailable
	{
		public int Id { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public decimal PricePerNight { get; set; }
		public bool IsAvailable { get; set; }
	}
	public class PropAmentity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}
	public class PropertyDetailsGetDto
	{
        public double RatingOverroll { get; set; }
        public int NumOfReview { get; set; }
        public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public string DisplayedImage { get; set; }
		public int Beds { get; set; }
		public string UserName { get; set; }
        public string UserImage { get; set; } = string.Empty;
        public string CategoryName { get; set; }
		public string CityName { get; set; }
		
		public int NumberOfGuest { get; set; }
		public bool Pets { get; set; }
		public bool TakePhotos { get; set; }
		public List<PropertyImagesGet> ImageUrl { get; set; }
		public List<PropAmentity> Amentities { get; set;}
		public List<PropAppoinmentAvailable> AppoinmentAvaiable { get; set; }
        public IEnumerable<Reviewdto> Reviews { get; set; } = new HashSet<Reviewdto>();
        public IEnumerable<PropertyBookingDates> BookingDates { get; set; } = new HashSet<PropertyBookingDates>();

    }

    public class PropertyBookingDates
    {
        public DateTime CheckInDate { get; set; } = DateTime.Now;
        public DateTime CheckOutDate { get; set; } = DateTime.Now;

    }
    public class Reviewdto
    {
        public int Id { get; set; }
        public string ReviewComment { get; set; } = string.Empty;
        public int Rate { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Userimage { get; set; } = string.Empty;
        
    }
    public class PaggenationsResultDto
	{
		public int Quantity { get; set; }
		public IEnumerable<PropertyGetDto> Properties { get; set; }
	}
	public class PropertyAddDto
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public string DisplayedImage { get; set; }
		public int Beds { get; set; }

		public int CategoryId { get; set; }
		public int CityId { get; set; }
	
		public int NumberOfGuest { get; set; }
		public bool Pets { get; set; }
		public bool TakePhotos { get; set; }
	}
	public class PropertyUpdateDto
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Adress { get; set; } = string.Empty;
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public string DisplayedImage { get; set; }
		public int Beds { get; set; }
		public string UserId { get; set; }
		public int CategoryId { get; set; }
		public int CityId { get; set; }
	}
}
