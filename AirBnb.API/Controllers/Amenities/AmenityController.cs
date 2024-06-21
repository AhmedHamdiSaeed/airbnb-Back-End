﻿using AirBnb.API.CustomAuth;
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
		[HttpPost("AddAmentity")]
		
		public async Task<IActionResult> Add(AmenityAddDto amenityAddDto)
		{
			if(ModelState.IsValid)
			{
				var result = await _amenityManager.AddAmentity(amenityAddDto);



				if (result is false)
					return BadRequest("Added Feild");
				return Ok(result);
			}
			return BadRequest("Data Not Valid");

		}


		// Update amenity
		[HttpPut("UpdateAmentity/{id}")]
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
		[HttpDelete("DeleteAmentity/{id}")]
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
		[HttpGet("GetAllPropAmentity/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllPropAmentity(int id)
		{
			try
			{
				
				return Ok(await _amenityManager.GetAllPropAmentity(id));
			}
			catch (Exception ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

	}
}
