using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Managers.Amenities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers.Amenities
{
	[Route("api/[controller]")]
	[ApiController]
	public class AmenityController : ControllerBase
	{
		private readonly IAmenityManager _amenityManager;
		public AmenityController(IAmenityManager amenityManger)
		{
			_amenityManager = amenityManger;
		}


		// Add amenity
		[HttpPost]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> Add(AmenityAddDto amenityAddDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			AmenityDto createdAmenity = await _amenityManager.Add(amenityAddDto);
			return Created("", createdAmenity);
		}


		// Update amenity
		[HttpPut]
		[Route("{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> Update(int id, AmenityAddDto amenityAddDto)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			try
			{
				AmenityDto updatedAmenity = await _amenityManager.Update(id, amenityAddDto);

				if (updatedAmenity == null)
					return NotFound(new { message = $"Amenity with ID {id} not found." });

				return Ok(updatedAmenity);
			}
			catch (Exception ex)
			{
				return StatusCode(500, (new { message = ex.Message }));
			}

		}

		// Delete amenity
		[HttpDelete]
		[Route("{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				await _amenityManager.Delete(id);
				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}


	}
}
