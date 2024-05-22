using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.UserRepo
{
	public interface IUserRepository
	{
		Task<AppUser> GetUserByIdAsync(string id);
		
	}
}
