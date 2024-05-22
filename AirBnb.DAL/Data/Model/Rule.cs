using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class Rule:BaseEntity<int>
	{

		public TimeOnly CheckIn { get; set; }
		public TimeOnly CheckOut { get; set; }
		public int NumberOfGuest { get; set; }
		public bool Pets { get; set; }
		public bool TakePhotos { get; set; }
		public int PropertyId { get; set; }
	}
}
