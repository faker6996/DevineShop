using MARShop.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.Base
{
    public interface IRepository<T> where T : AuditableEntity
    {
        #region add
        Task<T> DAddAsync(T entity);
        #endregion

        #region delete
        Task DDeleteAsync(T entity);
        Task DeleteByIdAsync(int id);
        Task DDeleteAsync(Expression<Func<T, bool>> predicate);
        #endregion

        #region update
        Task DUpdateAsync(T entity);
        #endregion

        #region get
        Task<T> DFistOrDefaultAsync(Func<T, bool> predicate);
        Task<T> DFistOrDefaultAsync();
        Task<IReadOnlyList<T>> DGetAllAsync();
        Task<IReadOnlyList<T>> DGetPagingAsync(int skip, int pageSize);
        Task<IReadOnlyList<T>> DGetAsync(Func<T, bool> predicate);
        Task<int> DGetTotalAsync();
        Task<T> DGetByIdAsync(int id);
        #endregion

    }
}
