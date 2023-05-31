using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence.Configurations
{
    public static class RolePermissionConfig
    {
        public static void SetRolePermissionForeignKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePermission>()
                       .HasOne<Role>(a => a.Role)
                       .WithMany(a => a.RolePermissions)
                       .HasForeignKey(a => a.RoleId);

            modelBuilder.Entity<RolePermission>()
                        .HasOne<Permission>(a => a.Permission)
                        .WithMany(a => a.RolePermissions)
                        .HasForeignKey(a => a.PermissionId);
        }
    }
}
