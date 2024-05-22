using AirBnb.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Repos.GenericRepo
{
	public interface IGenericRepository<T> where T : BaseEntity<int>
	{
		Task<IEnumerable<T>> GetAllAsync() ;
		Task<IEnumerable<T>> GetAllIncludedDataAsync(params Expression<Func<T, object>>[] includes);
		Task<T> GetByIdIncludedDataAsync(int id, params Expression<Func<T, object>>[] includes);
		Task<T>? GetByIdAsync(int id);
		Task AddAsync(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
