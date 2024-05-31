using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.ReviewsDtos
{
	public class ReviewsGetDto
	{
		public int Id { get; set; }
		public int BookingId { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; } = string.Empty;
	}

	public class ReviewsAddDto
	{
		public int BookingId { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; } = string.Empty;
	}

	public class ReviewsUpdateDto
	{
		public int BookingId { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; } = string.Empty;
	}
}
