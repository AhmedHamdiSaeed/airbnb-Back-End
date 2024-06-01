using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Data.Model
{
	public class AppointmentsAvailable:BaseEntity<int>
	{
		[ForeignKey(nameof(Property))]
        [Required]
        [Range(1, int.MaxValue)]
        public int PropertyId { get; set; }
		public Property Property { get; set; }

        [Required]
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PricePerNight { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
	}
}
