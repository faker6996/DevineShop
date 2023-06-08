using MARShop.Core.Common;
using MARShop.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
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

        // Create
        public async Task<T> DAddAsync(T entity)
        {
            var now = System.DateTime.Now;

            entity.Id = Guid.NewGuid().ToString();
            entity.Created = now;
            entity.LastModified = now;
            entity.IsDelete = false;
            await _db.AddAsync(entity);
            return entity;
        }

        // Delete
        public async Task DDeleteAsync(T entity)
        {
            entity.IsDelete = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task DeleteByIdAsync(string id)
        {
            var entity = await _db.FindAsync(id);
            entity.IsDelete = true;
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task DDeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var listExist = _db.Where(a => a.IsDelete == false);
            var listWithCondition = await listExist.Where(predicate).ToListAsync();
            foreach (var item in listWithCondition)
            {
                item.IsDelete = true;
                _context.Entry(item).State = EntityState.Modified;
            }
        }

        // Update
        public async Task DUpdateAsync(T entity)
        {
            entity.LastModified = System.DateTime.Now;
            entity.IsDelete = false;
            _context.Entry(entity).State = EntityState.Modified;
        }

        // Get
        public async Task<T> DFistOrDefaultAsync(Func<T, bool> predicate)
        {
            var item = _db.Where(a => a.IsDelete == false).FirstOrDefault(predicate);
            return item;
        }
        public async Task<T> DFistOrDefaultAsync()
        {
            return await _db.Where(a => a.IsDelete == false).FirstOrDefaultAsync();
        }
        public IQueryable<T> DGetAll()
        {
            return _db.Where(a => a.IsDelete == false);
        }
        public async Task<IReadOnlyList<T>> DGetPagingAsync(int skip, int pageSize)
        {
            return await _db.Where(a => a.IsDelete == false).Skip(skip).Take(pageSize).ToListAsync();
        }
        public IQueryable<T> DGet(Func<T, bool> predicate)
        {
            return  _db.Where(a => a.IsDelete == false).Where(predicate).AsQueryable();
        }
        public async Task<T> DGetByIdAsync(string id)
        {
            var entity = await _db.SingleOrDefaultAsync(t => t.Id.Equals(id));
            if (entity?.IsDelete == true)
            {
                return null;
            }
            return entity;
        }
        public DbSet<T> DGetDbSet() 
        {
            return _db;
        }
        // Count
        public async Task<int> DCountAsync()
        {
            return await _db.Where(a => a.IsDelete == false).CountAsync();
        }

    }
}
