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
        [HttpGet("GetAllCategories")]
        public ActionResult GetAllCategories([FromQuery]QueryParams queryParams)
		{
			var result = _categoryManager.GetAllCategories(queryParams);
			if (result is null)
				return Ok(new ApiResponse(404,"notFound","Data Empty"));
			return Ok(new ApiResponse(200,"success",result));	
		}
        #endregion

        #region GetCategoryById
        [HttpGet("GetCategoryDetails/{id}")]
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
        //[Authorize(Policy = "ForAdmin")]
		//[AuthorizeCurrentUser]
		public async Task<IActionResult> AddCategory([FromForm] CategoryAddDto category)
        {
            string[] allowExtenstion = [".jpg", ".jpeg", ".png"];

            if (!allowExtenstion.Contains(Path.GetExtension(category.IconURL.FileName), StringComparer.InvariantCultureIgnoreCase))
            { return BadRequest(new ApiResponse(400, "not support this extension", string.Empty)); }
            if (category.IconURL.Length > 2_000_000)
            {
                return BadRequest(new ApiResponse(400, "must less or equal 2MB", string.Empty));
            }

            var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(category.IconURL.FileName)}";
            var fullFilePath = Path.Combine(Environment.CurrentDirectory, "Assets", $"{newFileName}");
            using var stream = new FileStream(fullFilePath, FileMode.Create);
            category.IconURL.CopyTo(stream);


            var newCategory = await _categoryManager.AddCategory(new CategoryDto(category.Name, $"{Request.Scheme}://{Request.Host}/Assets/{newFileName}", category.Desc));
            return Ok(new ApiResponse(201, "created", newCategory));

        }
        #endregion

        #region UpdateCategory
        [HttpPut("UpdateCategory/{id}")]  //admin
        [Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateCategory([FromForm] CategoryEditDto category)
        {
            string[] allowExtenstion = [".jpg", ".jpeg", ".png"];

            if (!allowExtenstion.Contains(Path.GetExtension(category.IconURL.FileName), StringComparer.InvariantCultureIgnoreCase))
            { return BadRequest(new ApiResponse(400, "not support this extension", string.Empty)); }
            if (category.IconURL.Length > 2_000_000)
            {
                return BadRequest(new ApiResponse(400, "must less or equal 2MB", string.Empty));
            }

            var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(category.IconURL.FileName)}";
            var fullFilePath = Path.Combine(Environment.CurrentDirectory, "Assets", $"{newFileName}");
            using var stream = new FileStream(fullFilePath, FileMode.Create);
            category.IconURL.CopyTo(stream);


            var result = await _categoryManager.UpdateCategory(new CategoryEditDtoURL(category.id,category.Name, $"{Request.Scheme}://{Request.Host}/Assets/{newFileName}", category.Desc));
				if (result is false)
					return BadRequest(new ApiResponse(400,"faild",string.Empty));
			
			return Ok(new ApiResponse(200,"updated",string.Empty));
		}
		#endregion

        #region DeleteCategory
         [HttpDelete("DeleteCategory/{id}")] //admin
  //      [Authorize(Policy = "ForAdmin")]
		//[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteCategory(int categoryId)
		{
			var result =await _categoryManager.DeleteCategory(categoryId);
			if (result is false)
				return BadRequest("Feild In Deleting Data");
			return Ok(result);
		}
        #endregion




	}
}
