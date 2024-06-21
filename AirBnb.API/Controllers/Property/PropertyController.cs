using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.BL.Managers.Properties;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace AirBnb.API.Controllers.Property
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertyController : ControllerBase
	{
		private readonly IPropertyManager _propertyManager;
		private readonly UserManager<AppUser> _userManager;
		public PropertyController(IPropertyManager propertyManager, UserManager<AppUser> userManager)
		{
			_propertyManager = propertyManager;
			_userManager = userManager;
		}

		#region GetAllPropertyForAllUsers
		[HttpGet("GetAllPropertyForAllUsers")]
		public async Task<IActionResult> GetAllPropertyForAllUsers(int pageNumber , int pageSize , int? cityId = null, int? cateId = null)
		{
			if (pageNumber < 1 ) pageNumber = 1;
			if (pageSize < 2) pageSize = 2;

			var result = await _propertyManager.GetAllPropertyForAllUsers(pageNumber, pageSize, cityId, cateId);
			if (result == null) return NotFound("Data Is Empty");
			return Ok(result);
		}
		#endregion


		#region GetAllPropertyForAdmin
		[HttpGet("GetAllPropertyForAdmin")]

		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllPropertyForAdmin(int pageNumber, int pageSize, int? cityId = null, int? cateId = null)
		{
			var result = await _propertyManager.GetAllPropertyForAdmin(pageNumber, pageSize, cityId, cateId);
			if (result == null) return NotFound("Data Is Empty");
			return Ok(result);
		}
		#endregion
		#region GetPropertyDetailsById
		[HttpGet("GetPropertyDetailsById/{id}")]
		public async Task<IActionResult> GetPropertyDetailsById(int id)
		{
			var result = await _propertyManager.GetPropertyDetailsById(id);
			if (result == null) return NotFound($"Property With Id {id} Not Exist");
			return Ok(result);
		}
		#endregion

		#region GetHosterProperties
		[HttpGet("GetHosterProperties")]
		[Authorize]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetHosterProperties()
		{
			AppUser CurrentUser = await _userManager.GetUserAsync(User);
			var result = await _propertyManager.GetHosterProperties(CurrentUser.Id);
			if (result is null)
			{
				return NotFound("You Dont Have Any Property Yet");
			}
			return Ok(result);
		}

		#endregion
		[HttpPost("AddNewProperty")]
		public async Task<ActionResult> AddProperty(PropertyAddDto addProperty)
		{
			// Check if _propertyManager is null
			if (_propertyManager == null)
			{
				return BadRequest("Internal server error: Property manager not available.");
			}

			AppUser CurrentUser = await _userManager.GetUserAsync(User);

			if (ModelState.IsValid)
			{
				var result = await _propertyManager.AddProperty(addProperty, CurrentUser.Id);
				if (result is false)
				{
					return BadRequest("Add Field");
				}

				return Ok(result);
			}
			return BadRequest("Data Not Valid");

		}

		[HttpDelete("DeletePropertyById/{id}")]
		public async Task<IActionResult> DeleteProperty(int id)
		{
			var propertyDeleted = await _propertyManager.RemoveProperty(id);
			if (propertyDeleted)
			{
				return Ok("Property updated to disable future bookings.");
			}
			else
			{
				return BadRequest("Failed to update the property status.");
			}

		}
	}
}
