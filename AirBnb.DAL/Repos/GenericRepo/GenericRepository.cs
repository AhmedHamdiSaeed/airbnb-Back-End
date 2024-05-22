using AirBnb.DAL.Data.context;
using AirBnb.DAL.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.GenericRepo
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity<int>
	{
		private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
			_context=context;

		}
        public async Task AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			
		}

		public  void Delete(T entity)
		{
			 _context.Set<T>().Remove(entity);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _context.Set<T>().AsNoTracking().ToListAsync();
		}

		public async Task<IEnumerable<T>> GetAllIncludedDataAsync(params Expression<Func<T, object>>[] includes)
		{
			var query = _context.Set<T>().AsNoTracking().AsQueryable();
			foreach (var item in includes)
			{
				query = query.Include(item);
			}
			return await query.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<T> GetByIdIncludedDataAsync(int id, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = _context.Set<T>().Where(x => x.Id == id);
			foreach (var item in includes)
			{
				query = query.Include(item);
			}
			return await query.FirstOrDefaultAsync();
		}

		public  void Update(T entity)
		{
			 _context.Set<T>().Update(entity);
		}
	}
}
