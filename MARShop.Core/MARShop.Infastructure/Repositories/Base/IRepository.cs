using MARShop.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.Base
{
    public interface IRepository<T> where T : AuditableEntity
    {
        // Create
        Task<T> DAddAsync(T entity);

        // Delete
        Task DDeleteAsync(T entity);
        Task DeleteByIdAsync(int id);
        Task DDeleteAsync(Expression<Func<T, bool>> predicate);

        // Update
        Task DUpdateAsync(T entity);

        // Get
        Task<T> DFistOrDefaultAsync(Func<T, bool> predicate);
        Task<T> DFistOrDefaultAsync();
        IQueryable<T> DGetAll();
        Task<IReadOnlyList<T>> DGetPagingAsync(int skip, int pageSize);
        Task<IReadOnlyList<T>> DGetAsync(Func<T, bool> predicate);
        Task<T> DGetByIdAsync(int id);

        // Count
        Task<int> DCountAsync();
    }
}
