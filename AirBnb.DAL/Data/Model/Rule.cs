using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class Rule:BaseEntity<int>
	{
		public string Name { get; set; }=string.Empty;
		public string Description { get; set; }
		public IEnumerable<PropertyRule> PropertyRule { get; set;} =new HashSet<PropertyRule>();	
	}
}
