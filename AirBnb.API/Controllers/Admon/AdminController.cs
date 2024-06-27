using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.PropertyDtos;
using AirBnb.BL.Managers.Categories;
using AirBnb.BL.Managers.Properties;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.Admon
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdminController : ControllerBase
	{
		private readonly IPropertyManager _properyManager;
		private readonly UserManager<AppUser> _userManager;

		public AdminController(IPropertyManager properyManager, UserManager<AppUser> userManager)
		{
			_properyManager = properyManager;
			_userManager = userManager;
		}



		#region Update Property
		[HttpPut("UpdatePropertyByAdmin/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdatePropertyByAdmin(int id, PropertyUpdateByAdminDto updateProperty)
		{

			if (ModelState.IsValid)
			{
				bool result = await _properyManager.UpdatePropertyByAdmin(id, updateProperty);
				if (result is false)
				{
					return BadRequest("Field On Update Data");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion


	}
}
