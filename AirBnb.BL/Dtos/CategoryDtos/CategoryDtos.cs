using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CategoryDtos
{
	public class CategoryGetDtos  //get add 
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}

	public class CategoryEditDto //update delete 
	{
		
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}
	public class CategoryAddDto //update delete 
	{

		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}
}
