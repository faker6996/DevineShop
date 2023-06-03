using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MARShop.Infastructure.Persistence.Configurations.Relationship
{
    internal static class RelationshipConfig
    {
        public static void SetRelationshipConfig(this ModelBuilder modelBuilder)
        {
            // Relation between BlogPost_Tag and Tag
            modelBuilder.Entity<BlogPostTag>()
                        .HasOne(a => a.Tag)
                        .WithMany(a => a.BlogPostTags)
                        .HasForeignKey(a => a.TagId);

            // Realtion between BlogPost_Tag and BlogPost
            modelBuilder.Entity<BlogPostTag>()
                        .HasOne(a => a.BlogPost)
                        .WithMany(a => a.BlogPostTags)
                        .HasForeignKey(a => a.BlogPostId);

            // Realtion between Account_BlogPost and BlogPost
            modelBuilder.Entity<AccountBlogPost>()
                        .HasOne(a => a.BlogPost)
                        .WithMany(a => a.AccountBlogPosts)
                        .HasForeignKey(a => a.BlogPostId);
            
            // Realtion between Account_BlogPost and Account
            modelBuilder.Entity<AccountBlogPost>()
                        .HasOne(a => a.Account)
                        .WithMany(a => a.AccountBlogPosts)
                        .HasForeignKey(a => a.AccountId);
            
            // Realtion between Comment and Account
            modelBuilder.Entity<Comment>()
                        .HasOne(a => a.Account)
                        .WithMany(a => a.Comments)
                        .HasForeignKey(a => a.AccountId);
            
            // Realtion between Comment and BlogPost
            modelBuilder.Entity<Comment>()
                        .HasOne(a => a.BlogPost)
                        .WithMany(a => a.Comments)
                        .HasForeignKey(a => a.BlogPostId);
        }
    }
}
