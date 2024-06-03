using AirBnb.BL.Dtos.DtoUser;
using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Http;
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
		private readonly UserManager<AppUser> _userManager;
		private readonly IConfiguration _config;
		public UserController(UserManager<AppUser> userManager, IConfiguration config)
        {
			_userManager=userManager;
			_config=config;
		}


        #region Register3
        [HttpPost("Register")]
		public async Task<IActionResult> Register(RegisterDto user)
		{
			if (ModelState.IsValid)
			{
				AppUser newUser = new AppUser()
				{
					FirstName = user.firstName,
					LastName = user.lastName,
					UserName = $"{user.firstName}_{user.lastName}",
					Email = user.email,
					Role = (Role)user.role
				};

				IdentityResult reslut = await _userManager.CreateAsync(newUser, user.password);

				if (!reslut.Succeeded)
				{
					return BadRequest(reslut.Errors);
				}
				return Ok("Successed");
			}
			return BadRequest();
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

			var _token = new
			{
				token = new JwtSecurityTokenHandler().WriteToken(token),
				Role = result.Role.ToString(),
				userName = $"{result.FirstName} {result.LastName}",
				expiration = token.ValidTo
			};

			return Ok(_token);
		}
		#endregion
	}
}
