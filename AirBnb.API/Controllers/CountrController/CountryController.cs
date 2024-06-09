using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.CountryDtos;
using AirBnb.BL.Managers.Countries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.CountrController
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountryController : ControllerBase
	{
        private readonly ICountryManager _countryManager;
        public CountryController(ICountryManager countryManager)
        {
			_countryManager=countryManager;

		}

		#region GetAllCountry
		[HttpGet("GetAllCountry")]
		public async Task<IActionResult> GetAllCountry()
		{
			var result = _countryManager.GetAllCountry();
			if (result == null)
			{
				return BadRequest("Data Are Empty");
			}
			return Ok(result);
		}
		#endregion
		#region AddCountry
		[HttpPost("AddCountry")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddCountry(CountryAddDto addCountry)
		{
			if(ModelState.IsValid)
			{
				var result = await _countryManager.AddCountry(addCountry);
				if (result == false)
				{
					return BadRequest("Data Are Empty");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");

		}
		#endregion

		#region DeleteCountry
		[HttpDelete("DeleteCountry/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteCountry(int id)
		{
			var result = await _countryManager.DeleteCountry(id);
			if (result == false)
			{
				return BadRequest("Deleted Faild");
			}
			return Ok(result);
		}
		#endregion
		#region UpdateCountry
		[HttpPut("UpdateCountry/{id}")]
		[Authorize(Policy = "ForAdmin")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateCountry(int id, CountryUpdateDto updateCountry)
		{
			if(ModelState.IsValid)
			{
				var result = await _countryManager.UpdateCountry(id, updateCountry);
				if (result == false)
				{
					return BadRequest("Deleted Faild");
				}
				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
	}
}
