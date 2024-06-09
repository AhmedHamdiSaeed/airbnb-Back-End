using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.PropertyImagesDtos;
using AirBnb.BL.Managers.PropertiesImages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.PropertyImages
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertyImagesController : ControllerBase
	{
		private readonly IPropertyImagesManager _propertyImagesManager;

		public PropertyImagesController(IPropertyImagesManager propertyImagesManager)
        {
			_propertyImagesManager = propertyImagesManager;

		}

		#region GetAllPropertyImagesForProperty
		[HttpGet("GetAllPropertyImagesForProperty/{id}")]
		public async Task<IActionResult> GetAllPropertyImagesForProperty(int id) {
			var result = await _propertyImagesManager.GetAllPropertyImagesForProperty(id);
			if(result == null) { return  NotFound("Data Is Empty"); }
			return Ok(result);

		}
		#endregion
		#region AddImage
		[HttpPost("AddImage")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddImage(PropertyImagesAddAndUpdate img)
		{
			var result = await _propertyImagesManager.AddImage(img);
			if (result is false)
				return BadRequest("Added Feild");
			return Ok(result);
		}
		#endregion

		#region DeleteImage
		[HttpDelete("DeleteImage/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddImage(int id)
		{
			var result = await _propertyImagesManager.DeleteImage(id);
			if (result is false)
				return BadRequest("Deleted Feild");
			return Ok(result);
		}
		#endregion
		#region UpdateImage
		[HttpPut("UpdateImage/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateImage(int id, PropertyImagesAddAndUpdate img)
		{
			var result = await _propertyImagesManager.UpdateImage(id,  img);
			if (result is false)
				return BadRequest("Updated Feild");
			return Ok(result);
		}
		#endregion

	}
}
