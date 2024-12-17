using DevineShop.Core.Common;
using DevineShop.Core.Entities;
using DevineShop.Infastructure.Persistence.Configurations.Relationship;
using DevineShop.Infastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;

namespace DevineShop.Infastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetRelationshipConfig();
            modelBuilder.SeedInitial();

            // Cấu hình cho bảng Tag
            modelBuilder.Entity<Tag>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),    // Chuyển Local DateTime thành UTC trước khi lưu
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc)); // Chuyển về UTC khi lấy ra

            modelBuilder.Entity<Tag>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,    // Chuyển Local DateTime thành UTC trước khi lưu, xử lý nullable
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null); // Chuyển về UTC khi lấy ra

            // Cấu hình cho bảng BlogPost
            modelBuilder.Entity<BlogPost>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<BlogPost>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng BlogPostTag
            modelBuilder.Entity<BlogPostTag>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<BlogPostTag>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng Account
            modelBuilder.Entity<Account>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<Account>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng Comment
            modelBuilder.Entity<Comment>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<Comment>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng Notify
            modelBuilder.Entity<Notify>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<Notify>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng EmailConfig
            modelBuilder.Entity<EmailConfig>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<EmailConfig>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);

            // Cấu hình cho bảng Contact
            modelBuilder.Entity<Contact>()
                .Property(e => e.Created)
                .HasConversion(
                    v => v.ToUniversalTime(),
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            modelBuilder.Entity<Contact>()
                .Property(e => e.LastModified)
                .HasConversion(
                    v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
                    v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null);
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
