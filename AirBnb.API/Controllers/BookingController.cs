using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.BookingDtos;
using AirBnb.BL.Managers.BookingManagers;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingManager _bookingManager;
		private readonly UserManager<AppUser> _userManager;

		public BookingController(IBookingManager bookingManager, UserManager<AppUser> userManager)
        {
			_bookingManager = bookingManager;
			_userManager = userManager;
		}

		#region GetAllBookingForProperty
		[HttpGet("GetAllBookingForProperty/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllBookingForProperty(int id)
		{
			var result =await _bookingManager.GetAllBookingForProperty(id);
			if (result == null)
				return NotFound("Data Is Empty");

			return Ok(result);
		}
		#endregion


		#region GetPropertyBookingDetails
		[HttpGet("GetPropertyBookingDetails/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetPropertyBookingDetails(int id)
		{
			var result = await _bookingManager.GetPropertyBookingDetails(id);
			if (result == null)
				return NotFound("Data Is Empty");

			return Ok(result);
		}
		#endregion

		#region UpdateBooking
		[HttpPut("UpdateBooking/{id}/{obj}")]
		[Authorize]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateBooking(int id, BookingUpdateDto obj)
		{
			if(ModelState.IsValid)
			{
				
				var result = await _bookingManager.UpdateBooking(id, obj);
				if(result is false)
					return BadRequest("Update Feild");

				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion


		#region GetAllUserBooking
		[HttpGet("GetAllUserBooking")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllUserBooking()
		{
			AppUser CurrentUser = await _userManager.GetUserAsync(User);
			
				var result = await _bookingManager.GetAllUserBooking(CurrentUser.Id);
				if (result is null)
					return NotFound("Data Is Empty");

				return Ok(result);
			
		}
		#endregion

		#region GetUserBookingetails
		[HttpGet("GetUserBookingetails/{id}")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetUserBookingetails(int bookingid)
		{
			

			var result = await _bookingManager.GetUserBookingetails(bookingid);
			if (result is null)
				return NotFound("Data Is Empty");

			return Ok(result);

		}
		#endregion

		#region AddBooking
		[HttpPost("AddBooking/{obj}")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddBooking(AmentityGetDto amentity)
		{

			AppUser CurrentUser = await _userManager.GetUserAsync(User);

			if(ModelState.IsValid)
			{
				var result = await _bookingManager.AddBooking(CurrentUser.Id, amentity);
				if (result is false)
					return BadRequest("Add Field");

				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
	}
}
