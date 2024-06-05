using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.BL.Managers.Properties;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.Property
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertyController : ControllerBase
	{
		private readonly IPropertyManager _propertyManager;

		public PropertyController(IPropertyManager propertyManager)
		{
			_propertyManager = propertyManager;
		}

		[HttpGet("GetAllProperty")]
		public async Task<ActionResult<IEnumerable<DisplayAllPropertyDto>>> getAll()
		{
			var properties = await _propertyManager.GetAllProperty();
			if (properties == null) { return NotFound(); }
			return Ok(properties);
		}

		[HttpGet("GetPropertyById/{id}")]
		[AuthorizeCurrentUser]
		public async Task<ActionResult<GetPropertyDetailsDto>> getById(int id)
		{
			var property = await _propertyManager.GetPropertyDetailsById(id);
			if (property == null) { return NotFound(new { message = "Property not found." }); }
			return Ok(property);
		}
		[HttpPost("AddNewProperty")]
		public async Task<ActionResult> AddProperty(AddPropertyDto addProperty)
		{
			var res = await _propertyManager.AddProperty(addProperty);
			if (res)
			{
				return Ok("Property Is Added Sucssefully.");
			}
			return BadRequest("Could not add property.");
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
