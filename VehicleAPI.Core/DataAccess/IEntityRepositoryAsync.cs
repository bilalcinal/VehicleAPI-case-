using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using VehicleAPI.Core.Entities;

namespace VehicleAPI.Core.DataAccess;

public interface IEntityRepositoryAsync<T> where T : class, IEntity, new()
{
    Task<T> GetAsync(Guid id);

	Task<T> GetAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

	Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

	Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes);

    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);

}
