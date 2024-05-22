using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.AmentityDtos
{
	public class AmentityGetDto
	{
		public int Id { get; set; }
		public int PropertyId { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public int PricePerNight { get; set; }
		public int TotalProice { get; set; }
		public bool IsAvailable { get; set; }
	}
}
