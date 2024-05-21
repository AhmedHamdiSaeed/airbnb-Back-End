namespace AirBnb.DAL.Data.Model
{
	public class Country:BaseEntity<int>
	{
		public string Name { get; set; } = string.Empty;
		public IEnumerable<City> Cities { get; set;} =new HashSet<City>();
	}
}