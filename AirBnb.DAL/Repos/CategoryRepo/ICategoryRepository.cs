using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.CategoryRepo
{
	public interface ICategoryRepository : IGenericRepository<Category>
	{
	}
}
