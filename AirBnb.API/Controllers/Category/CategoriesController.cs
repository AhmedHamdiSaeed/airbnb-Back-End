using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Categories;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.Category
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryManager _categoryManager;
		private readonly UserManager<AppUser> _userManager;

		public CategoriesController(ICategoryManager categoryManager, UserManager<AppUser> userManager)
		{
			_categoryManager = categoryManager;
			_userManager = userManager;
		}

		[HttpGet("GetAllCategories")]
		public async Task<IActionResult> GetAllCategories()
		{
			var categories = await _categoryManager.GetAllCategories();
			if (categories is null)
			{
				return NotFound(new { message = $"Categories Is Not Found." });
			}
			return Ok(categories);
		}


		[HttpGet("GetCategoryDetails/{id}")]
		public async Task<IActionResult> GetCategoryById(int id)
		{
			var category = await _categoryManager.GetCategoryById(id);
			if (category == null)
			{
				return NotFound(new { message = $"Category with ID {id} not found." });
			}
			return Ok(category);
		}

		[HttpPost("AddCategory")] //admin
		public async Task<IActionResult> AddCategory(CategoryDtos categoryDto)
		{
			await _categoryManager.AddCategory(categoryDto);
			return Ok("Category Added Successfully!");
		}


		[HttpPut("UpdateCategory/{id}")]  //admin
		public async Task<IActionResult> UpdateCategory(int id, EditCategoryDtos categoryDto)
		{
			if (id != categoryDto.Id)
			{
				return BadRequest("Category ID mismatch");
			}

			if (ModelState.IsValid)
			{
				var result = await _categoryManager.UpdateCategory(categoryDto);
				if (!result)
				{
					return NotFound("Update failed, category not found");
				}

				return Ok("Category Updated Successfully!");
			}

			return BadRequest("Invalid data");
		}


		[HttpDelete("DeleteCategory/{id}")] //admin
		public async Task<IActionResult> DeleteCategory(int id)
		{
			var result = await _categoryManager.DeleteCategory(id);
			if (!result)
			{
				return BadRequest("Deleted Fail");
			}

			return Ok("Category Deleted Successfully !");
		}
	}
}
