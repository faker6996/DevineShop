using MARShop.Core.Common;
using MARShop.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : AuditableEntity
    {
        protected readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        #region add
        public async Task<T> DAddAsync(T entity)
        {
            entity.Created = System.DateTime.Now;
            entity.IsDelete = false;
            await _db.AddAsync(entity);
            return entity;
        }
        #endregion

        #region delete
        public async Task DDeleteAsync(T entity)
        {
            entity.IsDelete = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task DeleteByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            entity.IsDelete = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task DDeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var listExist = _context.Set<T>().Where(a => a.IsDelete == false);
            var listWithCondition = await listExist.Where(predicate).ToListAsync();
            foreach (var item in listWithCondition)
            {
                item.IsDelete = true;
                _context.Entry(item).State = EntityState.Modified;
            }
        }
        #endregion

        #region update
        public async Task DUpdateAsync(T entity)
        {
            entity.LastModified = System.DateTime.Now;
            entity.IsDelete = false;
            _context.Entry(entity).State = EntityState.Modified;
        }
        #endregion

        #region get
        public async Task<T> DFistOrDefaultAsync(Func<T, bool> predicate)
        {
            var listUseCondition = _db.Where(a => a.IsDelete == false);
            if (!listUseCondition.Any())
            {
                return null;
            }

            var listExist = await listUseCondition.ToListAsync();
            return listExist.FirstOrDefault(predicate);
        }
        public async Task<T> DFistOrDefaultAsync()
        {
            var listUseCondition = (IQueryable<T>)_db.Where(a => a.IsDelete == false);
            if (!listUseCondition.Any())
            {
                return null;
            }
            var listExist = await listUseCondition.ToListAsync();
            return listExist.First();
        }
        public async Task<IReadOnlyList<T>> DGetAllAsync()
        {
            return await _db.Where(a => a.IsDelete == false).ToListAsync();
        }
        public async Task<IReadOnlyList<T>> DGetPagingAsync(int skip, int pageSize)
        {
            return await _db.Where(a => a.IsDelete == false).Skip(skip).Take(pageSize).ToListAsync();
        }
        public async Task<IReadOnlyList<T>> DGetAsync(Func<T, bool> predicate)
        {
            var listExist = await _db.Where(a => a.IsDelete == false).ToListAsync();
            return listExist.Where(predicate).ToList();
        }
        public async Task<int> DGetTotalAsync()
        {
            return await _db.Where(a => a.IsDelete == false).CountAsync();
        }
        public async Task<T> DGetByIdAsync(int id)
        {
            var entity = await _db.FirstOrDefaultAsync(t => t.Id.Equals(id));
            _context.Entry(entity).State = EntityState.Detached;
            if (entity?.IsDelete == true)
            {
                return null;
            }
            return entity;
        }
        #endregion
    }
}
