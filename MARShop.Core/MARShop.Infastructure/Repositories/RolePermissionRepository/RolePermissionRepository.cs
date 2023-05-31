using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence;
using MARShop.Infastructure.Repositories.Base;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MARShop.Infastructure.Repositories.RolePermissionRepository
{
    public class RolePermissionRepository : Repository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Expression<Func<RolePermission, bool>> predicate)
        {
            await DDeleteAsync(predicate);
        }
    }
}
