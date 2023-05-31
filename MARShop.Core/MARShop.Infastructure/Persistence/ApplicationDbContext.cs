using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence.Configurations;
using MARShop.Infastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetAccountRoleForeignKeys();
            modelBuilder.SetRolePermissionForeignKeys();

            modelBuilder.SeedInitial();
        }
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Media> Medias => Set<Media>();
        public DbSet<History> Histories => Set<History>();
        public DbSet<OTP> OTPs => Set<OTP>();
        public DbSet<Permission> Permissions => Set<Permission>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
        public DbSet<Shop> Shops => Set<Shop>();
        public DbSet<AppInfo> AppInfos => Set<AppInfo>();
        public DbSet<AccountRole> AccountRoles => Set<AccountRole>();

    }
}
