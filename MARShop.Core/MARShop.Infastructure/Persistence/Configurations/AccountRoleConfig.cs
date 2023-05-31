using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence.Configurations
{
    public static class AccountRoleConfig
    {
        public static void SetAccountRoleForeignKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountRole>()
                       .HasOne<Account>(a => a.Account)
                       .WithMany(a => a.AccountRoles)
                       .HasForeignKey(a => a.AccountId);

            modelBuilder.Entity<AccountRole>()
                        .HasOne<Role>(a => a.Role)
                        .WithMany(a => a.AccountRoles)
                        .HasForeignKey(a => a.RoleId);
        }
    }
}
