using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class PropertyRule:BaseEntity<int>
	{
		[ForeignKey(nameof(Property))]
		public int PropertyId { get; set; }
		public Property Property { get; set; }
		[ForeignKey(nameof(Rule))]

		public int RuleId { get; set; }
		public Rule Rule { get; set; }
	}
}
