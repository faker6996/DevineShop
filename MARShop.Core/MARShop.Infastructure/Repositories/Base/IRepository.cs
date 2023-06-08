using MARShop.Core.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.Base
{
    public interface IRepository<T> where T : AuditableEntity
    {
        // Create
        Task<T> DAddAsync(T entity);

        // Delete
        Task DDeleteAsync(T entity);
        Task DeleteByIdAsync(string id);
        Task DDeleteAsync(Expression<Func<T, bool>> predicate);

        // Update
        Task DUpdateAsync(T entity);

        // Get
        Task<T> DFistOrDefaultAsync(Func<T, bool> predicate);
        Task<T> DFistOrDefaultAsync();
        IQueryable<T> DGetAll();
        Task<IReadOnlyList<T>> DGetPagingAsync(int skip, int pageSize);
        IQueryable<T> DGet(Func<T, bool> predicate);
        Task<T> DGetByIdAsync(string id);
        DbSet<T> DGetDbSet();
        
        // Count
        Task<int> DCountAsync();
    }
}
