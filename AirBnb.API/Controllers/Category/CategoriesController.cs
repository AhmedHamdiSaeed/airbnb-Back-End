using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Categories;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
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

		#region AddCategory
		[HttpPost("AddCategory")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddCategory([FromBody]CategoryAddDto newCate) {
			if(ModelState.IsValid)
			{
				var result =await _categoryManager.AddCategory(newCate);
				if (result is false)
					return BadRequest("Feild Added Category");
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
		#region DeleteCategory
		[HttpDelete("DeleteCategory/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteCategory(int categoryId)
		{
			var result =await _categoryManager.DeleteCategory(categoryId);
			if (result is false)
				return BadRequest("Feild In Deleting Data");
			return Ok(result);
		}
		#endregion

		#region GetAllCategories
		[HttpGet("GetAllCategories")]
		public async Task<IActionResult> GetAllCategories()
		{
			var result =await _categoryManager.GetAllCategories();
			if (result is null)
				return Ok("Data Empty");
			return Ok(result);	
		}
		#endregion
		#region GetCategoryById
		[HttpGet("GetCategoryById/{id}")]
		public async Task<IActionResult> GetCategoryById(int id)
		{
			var result =await _categoryManager.GetCategoryById(id);
			if (result is null)
				return Ok("Data Empty");
			return Ok(result);
		}
		#endregion

		#region UpdateCategory
		[HttpPut("UpdateCategory/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateCategory(int id,[FromBody] CategoryEditDto categoryDto)
		{
			if(ModelState.IsValid)
			{
				var result = await _categoryManager.UpdateCategory(id, categoryDto);
				if (result is false)
					return BadRequest("Delet Data Feild");
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion


	}
}
