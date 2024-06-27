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
		Task<List<CategoryReadDto>?> getAll();
		object? GetAllCategories(QueryParams queryParams );
		Task<GetOneCategoryDtos> GetCategoryById(int id);
		Task<bool> AddCategory(CategoryDto categoryDto);
		Task<bool> UpdateCategory(int id,CategoryDto categoryDto);
		Task<bool> DeleteCategory(int id);

		Task<IEnumerable<getAllCategoryDto>> getAllCategoryLastUpdate();
	}
}
