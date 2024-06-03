using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Categories
{
	public class CategoryManager : ICategoryManager
	{
		private readonly IUnitOfWork _unitOfWork;

		public CategoryManager(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task AddCategory(CategoryDtos categoryDto) //admin
		{
			var category = new Category
			{
				Name = categoryDto.Name,
				Description = categoryDto.IconUrl
			};

			await _unitOfWork.CategoryRepository.AddAsync(category);
			_unitOfWork.SaveChanges();
		}

		public async Task<IEnumerable<CategoryDtos>> GetAllCategories() //user 
		{
			var categories = await _unitOfWork.CategoryRepository.GetAllAsync();
			return categories.Select(c => new CategoryDtos
			{
				Name = c.Name,
				IconUrl = c.Description
			}).ToList();
		}


		public async Task<CategoryDtos> GetCategoryById(int id) //user
		{
			Category category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
			if (category is null)
			{
				return null;
			}
			return new CategoryDtos
			{
				Name = category.Name,
				IconUrl = category.Description
			};
		}


		//public async Task<CategoryDtos> GetCategoryById(int id)
		//{
		//    // Include related data using projection with Include
		//    var category = await _unitOfWork.CategoryRepository
		//        .GetByIdAsync(id, c => c.Include(x => x.Properties)); // Include Properties property

		//    if (category == null)
		//    {
		//        return null;
		//    }

		//    // Map to DTO with potential adjustments for included data
		//    return new CategoryDtos
		//    {
		//        Name = category.Name,
		//        IconUrl = category.Description, // Double-check if this is correct
		//        Properties = category.Properties.Select(p => new PropertyDto // Project properties to DTOs
		//        {
		//            // ... (map property properties to PropertyDto)
		//        }).ToList()
		//    };
		//}

		public async Task<bool> DeleteCategory(int id)  //admin
		{
			Category category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
			if (category is null)
			{
				return false;
			}

			_unitOfWork.CategoryRepository.Delete(category);
			_unitOfWork.SaveChanges();
			return true;
		}

		public async Task<bool> UpdateCategory(EditCategoryDtos categoryDto) //admin
		{
			Category category = await _unitOfWork.CategoryRepository.GetByIdAsync(categoryDto.Id);
			if (category is null)
			{
				return false;
			}

			category.Name = categoryDto.Name;
			category.Description = categoryDto.IconUrl;

			_unitOfWork.CategoryRepository.Update(category);
			_unitOfWork.SaveChanges();
			return true;
		}
	}
}
