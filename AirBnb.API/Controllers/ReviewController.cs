using AirBnb.API.CustomAuth;
using AirBnb.BL.Dtos.ReviewsDtos;
using AirBnb.BL.Managers.BookingManagers;
using AirBnb.BL.Managers.Reviews;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AirBnb.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReviewController : ControllerBase
	{
		private readonly IReviewManager _ReviewsManager;
		private readonly UserManager<AppUser> _userManager;

		public ReviewController(IReviewManager reviewsManager, UserManager<AppUser> userManager)
		{
			_ReviewsManager = reviewsManager;
			_userManager = userManager;
		}


		#region Gett All Booking Review
		[HttpPost("AddReview")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> AddReview(ReviewsAddDto review)
		{

			AppUser CurrentUser = await _userManager.GetUserAsync(User);
			if(ModelState.IsValid)
			{
				var result = await _ReviewsManager.AddReview(CurrentUser.Id, review);
				if(result is false)
					return BadRequest("Add Fail");

				return Ok("Added Succesfuly");
			}
			return BadRequest("Data Not Valid");

		}
		#endregion


		#region DeleteReview
		[HttpDelete("DeleteReview/{id}")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async  Task<IActionResult> DeleteReview(int id)
		{
			var result = await _ReviewsManager.DeleteReview(id);
			if (result is false)
				return BadRequest("Deleted Fail");
			return Ok("Deleted Succesfuly");
		}
		#endregion

		#region GetAllBookingReviews
		[HttpGet("GetAllBookingReviews/{id}")]
		[Authorize(Policy = "ForHost")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllBookingReviews(int bookingid)
		{
			var result = await _ReviewsManager.GetAllBookingReviews(bookingid);
			if (result is null)
				return BadRequest("Data Not Found, Its Empty");

			return Ok(result);
		}
		#endregion


		#region GetAllUserReviews
		[HttpGet("GetAllUserReviews")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetAllUserReviews()
		{
			AppUser CurrentUser = await _userManager.GetUserAsync(User);

			var result = await _ReviewsManager.GetAllUserReviews(CurrentUser.Id);
			if (result is null)
				return BadRequest("Data Not Found, Its Empty");

			return Ok(result);
		}
		#endregion


		#region GetReviewDetails
		[HttpGet("GetReviewDetails/{id}")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> GetReviewDetails(int id)
		{
			

			var result = await _ReviewsManager.GetReviewDetails(id);
			if (result is null)
				return BadRequest("Data Not Found, Its Empty");

			return Ok(result);
		}
		#endregion

		#region UpdateReview
		[HttpPut("UpdateReview/{id}/{obj}")]
		[Authorize(Policy = "ForUser")]
		[AuthorizeCurrentUser]
		public async Task<IActionResult> UpdateReview(int id, ReviewsUpdateDto obj)
		{


			if(ModelState.IsValid)
			{
				var result = await _ReviewsManager.UpdateReview(id, obj);
				if (result is false)
					return BadRequest("Update Fail");

				return Ok(result);
			}
			return BadRequest("Data Not Valid");
		}
		#endregion
	}
}
