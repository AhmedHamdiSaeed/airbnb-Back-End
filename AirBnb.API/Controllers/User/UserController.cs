using AirBnb.BL.Dtos.DtoUser;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AirBnb.API.Controllers.User
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		string? tok=null;
		private readonly UserManager<AppUser> _userManager;
		private readonly IConfiguration _config;
		private readonly ILogger<UserController> _logger;
		public UserController(UserManager<AppUser> userManager, IConfiguration config, ILogger<UserController> logger)
        {
			_userManager=userManager;
			_config=config;
		}

		
		#region Register3
		[HttpPost("Register")]
		public async Task<IActionResult> Register(RegisterDto user)
		{
			try
			{
				if (ModelState.IsValid)
				{


					var emailExist = await _userManager.FindByEmailAsync(user.email);
					if (emailExist != null)
					{
						return BadRequest("Email already exists");
					}
					AppUser newUser = new AppUser()
					{
						FirstName = user.firstName,
						LastName = user.lastName,
						UserName = $"{Guid.NewGuid()}",
						Email = user.email,
						Role = (Role)user.role,
					};

					IdentityResult reslut = await _userManager.CreateAsync(newUser, user.password);

					if (!reslut.Succeeded)
					{
						return BadRequest(reslut.Errors);
					}
					return Ok("Successed");


				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while registering the user.");
				return StatusCode(500, new { message = "Internal server error" });
			}
		}
		#endregion

		#region Login

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginDto user)
		{

			AppUser? result = await _userManager.FindByEmailAsync(user.email);

			if (result is null)
			{
				return BadRequest("Invalid Email Or Password");
			}

			if (!_userManager.CheckPasswordAsync(result, user.password).GetAwaiter().GetResult())
			{
				return BadRequest("Password Is UnCorrect");
			}
			var Myclaims = new List<Claim>();
			Myclaims.Add(new Claim(ClaimTypes.Name, result.FirstName));
			Myclaims.Add(new Claim(ClaimTypes.Email, result.Email));
			Myclaims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id));
			Myclaims.Add(new Claim(ClaimTypes.Role, result.Role.ToString()));
			Myclaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

			// SigningCredentials
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SecretKey"]));
			var sc = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			//
			var token = new JwtSecurityToken(
				claims: Myclaims,
				issuer: _config["JWT:Issuer"],
				audience: _config["JWT:Audience"],
				expires: DateTime.Now.AddDays(10),
				signingCredentials: sc
				);

			var _token = new
			{
				token = new JwtSecurityTokenHandler().WriteToken(token),
				Role = result.Role.ToString(),
				userName = $"{result.FirstName} {result.LastName}",
				userId = result.Id,
				expiration = token.ValidTo
			};
			tok = _token.token;
			return Ok(_token);
		}
		#endregion


		[HttpGet("check-email-exist")]
		public async Task<ActionResult<bool>> CheckEmailExist(string email)
		{
			var result = await _userManager.FindByEmailAsync(email);
			if (result is not null)
			{
				return true;
			}
			return false;
		}



		[Authorize]
		[HttpGet("get-current-user")]
		public async Task<IActionResult> GetCurrentUser()
		{

			AppUser result = await _userManager.GetUserAsync(User);
			var Myclaims = new List<Claim>();
			Myclaims.Add(new Claim(ClaimTypes.Name, result.UserName));
			Myclaims.Add(new Claim(ClaimTypes.Email, result.Email));
			Myclaims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id));
			Myclaims.Add(new Claim(ClaimTypes.Role, result.Role.ToString()));
			Myclaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

			// SigningCredentials
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SecretKey"]));
			var sc = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			//
			var token = new JwtSecurityToken(
				claims: Myclaims,
				issuer: _config["JWT:Issuer"],
				audience: _config["JWT:Audience"],
				expires: DateTime.Now.AddDays(10),
				signingCredentials: sc
				);

			//var email = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;
			//var User = await _userManager.FindByEmailAsync(email);
			//return Ok(new
			//{
			//	email = User.Email,
			//	firstName = User.FirstName,
			//	lastName = User.LastName,
			//	Id = User.Id,
			//});
			return Ok(new
				{
				    firstName = result.FirstName,
					lastName = result.LastName,
					phoneNumber = result.PhoneNumber,
					age= result.Age,
					DisplayName = $"{result.FirstName} {result.LastName}",
					image=result.Image,
					Email = result.Email,
				ImageUrl = result.Image,
				Token = new JwtSecurityTokenHandler().WriteToken(token)

			}); ;


		}


		#region Update User Information

		[HttpPut("UpdateUser")]
		[Authorize]

		public async Task<IActionResult> updateUserData(updateUserDto userData)
		{
			var currentUser = await _userManager.GetUserAsync(User);
			if (currentUser == null)
			{
				return NotFound(new { success = false, message = "User not found" });
			}

			currentUser.Email = userData.email;
			currentUser.FirstName = userData.firstName;
			currentUser.LastName = userData.lastName;
			currentUser.Age = userData.age;
			currentUser.PhoneNumber = userData.phoneNumber;
			currentUser.Image = userData.Image;

			IdentityResult result = await _userManager.UpdateAsync(currentUser);
			if (!result.Succeeded)
			{
				return BadRequest(new { success = false, message = "Failed to update user data", errors = result.Errors });
			}

			return Ok(new { success = true, message = "User profile updated successfully" });
		}

		#endregion
	}
}
