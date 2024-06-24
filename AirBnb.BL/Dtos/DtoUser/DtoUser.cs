using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.DtoUser
{
	public class RegisterDto
	{
		[Required]
		public string email { get; set; }
		[Required]

		public string password { get; set; }
		[Required]
		public string confirmpassword { get; set; }
		[Required]

		public string firstName { get; set; }
		[Required]

		public string lastName { get; set; }
		[Required]
		public int role {  get; set; }

		
	}

	public class LoginDto
	{
		[Required]
		public string email { get; set; }
		[Required]

		public string password { get; set; }
	}

	public class updateUserDto
	{
		public string email { get; set; }

		public string firstName { get; set; }
		public string lastName { get; set; }
		public int age { get; set; }
		public string phoneNumber { get; set; }
		public string Image { get; set; }
	}
}
