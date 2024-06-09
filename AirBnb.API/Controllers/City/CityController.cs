using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.CityDtos;
using AirBnb.BL.Managers.Cities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.City
{
	[Route("api/[controller]")]
	[ApiController]
	public class CityController : ControllerBase
	{
        public readonly ICityManager _cityManager;
        public CityController(ICityManager cityManager)
        {
            _cityManager = cityManager;
        }

		#region GetAllCities
		[HttpGet("GetAllCities")]
		public async Task<IActionResult> GetAllCities()
		{
			var result =await _cityManager.GetAllCities();
			if (result is null) return BadRequest("Data Is Enpty");
			return Ok(result);
		}
		#endregion

		#region addCity
		[HttpPost("addCity")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> addCity( CityAddDto city)
		{
			if(ModelState.IsValid)
			{
				bool result =await _cityManager.addCity(city);
				if(result is false)
				{
					return BadRequest("Field On Add Data");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion

		#region UpdateCity
		[HttpPut("UpdateCity/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateCity(int id,  CityUpdateDto city)
		{
			if (ModelState.IsValid)
			{
				bool result = await _cityManager.UpdateCity(id, city);
				if (result is false)
				{
					return BadRequest("Field On Update Data");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
		#region DeleteCity
		[HttpDelete("DeleteCity/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteCity(int id)
		{
			
				bool result = await _cityManager.DeleteCity(id);
				if (result is false)
				{
					return BadRequest("Field On Delete Data");
				}
				return Ok(result);
			
		}
		#endregion
	}
}
