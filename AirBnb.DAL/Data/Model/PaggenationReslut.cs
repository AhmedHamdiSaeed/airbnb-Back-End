using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class PaggenationReslut
	{
		public int Quantity { get; set; }
		public IEnumerable<Property> Properties { get; set; }
	}
}
