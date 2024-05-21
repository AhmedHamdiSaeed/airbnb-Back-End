using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnb.DAL.Data.Model
{
	public class City:BaseEntity<int>
	{
		public string Name { get; set; } = string.Empty;
		[ForeignKey(nameof(Country))]
		public int CountryId { get; set; }
		public Country Country { get; set; }

	}
}