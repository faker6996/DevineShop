using MARShop.Core.Entities;
using MARShop.Infastructure.Persistence.Configurations.Relationship;
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
            modelBuilder.SetRelationshipConfig();
            modelBuilder.SeedInitial();
        }
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<BlogPostTag> BlogPostTags => Set<BlogPostTag>();
        public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
        public DbSet<AccountBlogPost> AccountBlogPosts => Set<AccountBlogPost>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<EmailConfig> EmailConfigs => Set<EmailConfig>();
        public DbSet<Notify> Notifies => Set<Notify>();
        public DbSet<Contact> Contacts => Set<Contact>();
    }
}
