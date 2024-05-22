using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class AppointmentsAvailable:BaseEntity<int>
	{
		public int PropertyId { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public decimal PricePerNight { get; set; }
		public bool IsAvailable { get; set; }
	}
}
