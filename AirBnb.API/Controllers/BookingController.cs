using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.BL.Dtos.AppointmentAvailableDtos;
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
		//[Authorize(Policy = "ForHost")]
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
				return Ok("Data Is Empty");

			return Ok(result);
		}
		#endregion

		#region UpdateBooking
		[HttpPut("UpdateBooking/{id}")]
		[Authorize]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateBooking(int id, BookingUpdateDto obj)
		{
			if(ModelState.IsValid)
			{
				
				var result = await _bookingManager.UpdateBooking(id, obj);
				if(result is false)
					return Ok("Update Feild");

				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion


		#region GetAllUserBooking
		[HttpGet("GetAllUserBooking")]
		//[Authorize(Policy = "ForUser")]
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

		#region Delete Booking
		[HttpDelete("DeleteBooking/{id}")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> DeleteBooking(int id)
		{
			var result = await _bookingManager.DeleteBookingAsync(id);
			if (!result)
			{
				return NotFound(new { message = "Booking not found" });
			}

			return Ok(new { message = "Booking deleted successfully" });
		}
		#endregion

		#region GetUserBookingetails
		[HttpGet("GetUserBookingetails/{id}")]
		//[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetUserBookingetails(int id)
		{
			

			var result = await _bookingManager.GetUserBookingetails(id);
			if (result is null)
				return NotFound("Data Is Empty");

			return Ok(result);

		}
		#endregion
			
		#region AddBooking
		[HttpPost("AddBooking")]
		[Authorize(Policy = "ForUser")]
		//[AuthorizeCurrentUser]
		public async Task<IActionResult> AddBooking(appAvailbletGetDto bookingAdd)
		{

			AppUser CurrentUser = await _userManager.GetUserAsync(User);

			if (ModelState.IsValid)
			{
				var result = await _bookingManager.AddBooking(CurrentUser.Id, bookingAdd);
				if (result is false)
					return BadRequest("Add Field");

				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion

		#region AdddBooking
		[HttpPost("AdddBooking")]
		[Authorize(Policy = "ForUser")]

		public async Task<IActionResult> AdddBooking(BookingAddDto bookingAdd)
		{

			AppUser CurrentUser = await _userManager.GetUserAsync(User);

			if (ModelState.IsValid)
			{
				var bookingId = await _bookingManager.AdddBooking(CurrentUser.Id, bookingAdd);
				if (bookingId == null)
					return BadRequest("Add Failed");

				return Ok(bookingId);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
	}
}
