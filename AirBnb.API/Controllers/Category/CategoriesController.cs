using AirBnb.API.CustomAuth;
using AirBnb.API.Extentions;
using AirBnb.BL.Dtos.CategoryDtos;
using AirBnb.BL.Managers.Categories;
using AirBnb.BL.Managers.Services;
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

        #region GetAllCategories




        [HttpGet("GetAll")]
        public async Task<ActionResult> Category() 
        {
            var categories=await _categoryManager.getAllCategoryLastUpdate();
            if (categories == null)
                return NotFound(new ApiResponse(404,"notFound",string.Empty));
            return Ok(categories);
            //return Ok(new ApiResponse(200,"success",categories));
        }

        [HttpGet("GetAllCategories")]
        [Authorize(Policy = "ForAdmin")]
        [AuthorizeCurrentUser]
        public ActionResult GetAllCategories([FromQuery]QueryParams queryParams)
		{
			var result = _categoryManager.GetAllCategories(queryParams);
			if (result is null)
				return Ok(new ApiResponse(404,"notFound","Data Empty"));
			return Ok(new ApiResponse(200,"success",result));	
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

        #region AddCategory
        [HttpPost("AddCategory")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddCategory(CategoryDto category)
        {
			//string[] allowExtenstion = [".jpg", ".jpeg", ".png"];

			//if (!allowExtenstion.Contains(Path.GetExtension(category.IconURL.FileName), StringComparer.InvariantCultureIgnoreCase))
			//{ return BadRequest(new ApiResponse(400, "not support this extension", string.Empty)); }
			//if (category.IconURL.Length > 2_000_000)
			//{
			//    return BadRequest(new ApiResponse(400, "must less or equal 2MB", string.Empty));
			//}

			//var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(category.IconURL.FileName)}";
			//var fullFilePath = Path.Combine(Environment.CurrentDirectory, "Assets", $"{newFileName}");
			//using var stream = new FileStream(fullFilePath, FileMode.Create);
			//category.IconURL.CopyTo(stream);


			//var newCategory = await _categoryManager.AddCategory(new CategoryDto(category.Name, $"{Request.Scheme}://{Request.Host}/Assets/{newFileName}", category.Desc));
			//return Ok(new ApiResponse(201, "created", newCategory));.

			if (ModelState.IsValid)
			{
				bool result = await _categoryManager.AddCategory(category);
				if (result is false)
				{
					return BadRequest("Field On Add Data");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
        #endregion

        #region UpdateCategory
        [HttpPut("UpdateCategory/{id}")]  //admin
        [Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateCategory(int id,CategoryDto category)
        {
  

			if (ModelState.IsValid)
			{
				bool result = await _categoryManager.UpdateCategory(id,category);
				if (result is false)
				{
					return BadRequest("Field On Update Data");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion

        #region DeleteCategory
         [HttpDelete("DeleteCategory/{id}")] //admin
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteCategory(int id)
		{
			var result =await _categoryManager.DeleteCategory(id);
			if (result is false)
				return BadRequest("Feild In Deleting Data");
			return Ok(result);
		}
        #endregion




	}
}
