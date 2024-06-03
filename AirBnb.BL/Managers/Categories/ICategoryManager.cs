using AirBnb.BL.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Categories
{
	public interface ICategoryManager
	{
		Task<IEnumerable<CategoryDtos>> GetAllCategories();
		Task<CategoryDtos> GetCategoryById(int id);
		Task AddCategory(CategoryDtos categoryDto); //return void 
		Task<bool> UpdateCategory(EditCategoryDtos categoryDto);
		Task<bool> DeleteCategory(int id);
	}
}
