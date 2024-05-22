using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.UserRepo
{
	public class UserRepository : IUserRepository
	{
		private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;

        }
       

		public async Task<AppUser> GetUserByIdAsync(string id)
		{
			return  await _context.Set<AppUser>().FindAsync(id);
		}

		
	}
}
