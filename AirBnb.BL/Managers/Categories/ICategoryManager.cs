using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Categories
{
	public interface ICategoryManager
	{
        object? GetAllCategories(QueryParams queryParams );
		Task<CategoryDto> GetCategoryById(int id);
		Task<bool> AddCategory(CategoryDto categoryDto);
		Task<bool> UpdateCategory(CategoryEditDtoURL categoryDto);
		Task<bool> DeleteCategory(int id);
	}
}
