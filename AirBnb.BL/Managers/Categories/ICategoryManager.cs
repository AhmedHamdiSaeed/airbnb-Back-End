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
		Task<IEnumerable<CategoryGetDtos>> GetAllCategories();
		Task<CategoryGetDtos> GetCategoryById(int id);
		Task<bool> AddCategory(CategoryAddDto categoryDto); //return void 
		Task<bool> UpdateCategory(int cateId ,CategoryEditDto categoryDto);
		Task<bool> DeleteCategory(int id);
	}
}
