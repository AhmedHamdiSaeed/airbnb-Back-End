namespace AirBnb.DAL.Data.Model
{
	public class Category:BaseEntity<int>
	{
		public string Name { get; set; }=null!;	
		public string Description { get; set; }=string.Empty ;
		public string IconURL { get; set; } = null!;
        public IEnumerable<Property> Properties { get; set; }=new HashSet<Property>();

	}
}