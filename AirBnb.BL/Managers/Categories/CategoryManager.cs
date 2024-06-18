
using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Services;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using Microsoft.IdentityModel.Tokens;
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

		public async Task<bool> AddCategory(CategoryDto categoryDto)
		{
			Category getCate = new Category()
			{
				Name = categoryDto.Name,
				Description = categoryDto.Desc,
				IconURL = categoryDto.IconURL,
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

		public  object GetAllCategories(QueryParams queryParams)
		{
			var query = _unitOfWork.CategoryRepository.getAll();
			if(query is null ) { return null; }
			if (!string.IsNullOrWhiteSpace(queryParams.SearchTerm))
				query = query.Where(c=>c.Name.Contains(queryParams.SearchTerm.ToLower()));
			if (!string.IsNullOrWhiteSpace(queryParams.SortBy))
				if(queryParams.SortBy.ToLower()=="Name")
				query = query.OrderBy(c=>c.Name);
            //paging
            var Total = query.Count();
            var totalPages = Total / queryParams.PageSize;
            if (totalPages < 1) totalPages = 1;
            var skipAmount = (queryParams.PageNumber - 1) * queryParams.PageSize;
            return  new QueryResult(query.Skip(skipAmount).Take(queryParams.PageSize).Select(c => new CategoryDto(c.Name,c.IconURL,c.Description)).ToList(),totalPages, queryParams.PageNumber, queryParams.PageSize, Total);
        }
    

		public async Task<CategoryDto> GetCategoryById(int id)
		{
			Category category = await _unitOfWork.CategoryRepository.GetByIdAsync(id) ;
			if (category is null) return null;
			return new CategoryDto(category.Name,category.IconURL,category.Description);
	}

		public async Task<bool> UpdateCategory(CategoryEditDtoURL category)
		{
			Category cate = await _unitOfWork.CategoryRepository.GetByIdAsync(category.id);
			cate.Name = category.Name;
			cate.Description = category.Desc;
			cate.IconURL = category.IconURL;
			_unitOfWork.CategoryRepository.Update(cate);
			return _unitOfWork.SaveChanges() >0;
		}
	}
}
