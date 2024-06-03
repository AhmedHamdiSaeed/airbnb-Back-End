using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CategoryDtos
{
	public class CategoryDtos  //get add 
	{
		public string Name { get; set; } // "Amazing pools", "Beachfront" ....
		public string IconUrl { get; set; } //icon image

		//public string Description { get; set; } 
	}

	public class EditCategoryDtos //update delete 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string IconUrl { get; set; }
	}
}
