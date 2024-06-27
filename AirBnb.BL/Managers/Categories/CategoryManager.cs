
using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Dtos.PropertyDtos;
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

		public async Task<List<CategoryReadDto>> getAll()
		{
			var categories= _unitOfWork.CategoryRepository.getAll().ToList();
			if(categories==null)
				return null;
			return categories.Select(c=>new CategoryReadDto(c.Name,c.IconURL)).ToList();
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
    
		public async Task<IEnumerable<CategoryReadDto>?> getCategories()
		{
			var categories=await _unitOfWork.CategoryRepository.GetAllAsync();
            if (categories is null) return null;
            return   categories.Select(c=>new CategoryReadDto(c.Name,c.IconURL));
        }

        public async Task<GetOneCategoryDtos> GetCategoryById(int id)
		{
			Category category = await _unitOfWork.CategoryRepository.GetPropertiesOfCategory(id) ;
			if (category is null) return null;
			return new GetOneCategoryDtos
			{
				Id=category.Id,
				Name=category.Name,
				IconURL=category.IconURL,
				Description=category.Description,
                Properties = category.Properties.Select(p => new PropertyGetDto
                {
                    Id = p.Id,
                    Name = p.Name,
					Description = p.Description,
                    DisplayedImage=p.DisplayedImage,

                }).ToList()
            };
		}

		public async Task<bool> UpdateCategory(int id,CategoryDto category)
		{
			Category cate = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
			cate.Name = category.Name;
			cate.Description = category.Desc;
			cate.IconURL = category.IconURL;
			_unitOfWork.CategoryRepository.Update(cate);
			return _unitOfWork.SaveChanges() >0;
		}

		public async Task<IEnumerable<getAllCategoryDto>> getAllCategoryLastUpdate()
		{
			IEnumerable<Category> allCate =await _unitOfWork.CategoryRepository.GetAllAsync();
			if(allCate is null)
			{
				return null;
			}
			var result = allCate.Select(x => new getAllCategoryDto
			{
				Id = x.Id,
				Name = x.Name,
				IconURL = x.IconURL,

			}).ToList();
			return result;
		}
	}
}
