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

		public async Task<bool> AddCategory(CategoryAddDto categoryDto)
		{
			Category getCate = new Category()
			{
				Name = categoryDto.Name,
				Description = categoryDto.Description,
			};
			await _unitOfWork.CategoryRepository.AddAsync(getCate);
			return  _unitOfWork.SaveChanges() > 0;
		}

		public async Task<bool> DeleteCategory(int id)
		{
			Category result =await  _unitOfWork.CategoryRepository.GetByIdAsync(id);
			  _unitOfWork.CategoryRepository.Delete(result);
			return _unitOfWork.SaveChanges()>0;

		}

		public async Task<IEnumerable<CategoryGetDtos>> GetAllCategories()
		{
			IEnumerable<Category> getAllCategory =await _unitOfWork.CategoryRepository.GetAllAsync();
			if(getAllCategory is null ) { return null; }
			var result = getAllCategory.Select(x => new CategoryGetDtos
			{
				Id = x.Id,
				Name = x.Name,
				Description = x.Description,
			})
			;
			return result ;
		}

		public async Task<CategoryGetDtos> GetCategoryById(int id)
		{
			Category getCate = await _unitOfWork.CategoryRepository.GetByIdAsync(id) ;
			if (getCate is null) return null;
			CategoryGetDtos result = new CategoryGetDtos
			{
				Name = getCate.Name,
				Description = getCate.Description,
				Id = getCate.Id,
			};
			return result;
	}

		public async Task<bool> UpdateCategory(int cateId,CategoryEditDto categoryDto)
		{
			Category myCate = await _unitOfWork.CategoryRepository.GetByIdAsync(cateId);
			myCate.Name = categoryDto.Name;
			myCate.Description = categoryDto.Description;
			_unitOfWork.CategoryRepository.Update(myCate);
			return _unitOfWork.SaveChanges() >0;
		}
	}
}
