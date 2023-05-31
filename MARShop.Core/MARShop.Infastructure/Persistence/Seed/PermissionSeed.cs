using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MARShop.Infastructure.Persistence.Seed
{
    public static class PermissionSeed
    {
        public static void SeedPermission(this ModelBuilder modelBuilder)
        {
            IList<Permission> permissions = new List<Permission>();

            //permission for media
            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id = 1,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "media-create",
                    Title = "Thêm media"
                },
                new Permission()
                {
                    Id = 2,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "media-update",
                    Title = "Sửa media"
                },
                new Permission()
                {
                    Id = 3,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "media-delete",
                    Title = "Xóa media"
                },
                new Permission()
                {
                    Id = 4,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "media-get",
                    Title = "Xem media"
                }
            ); ;

            //permission for shop
            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id= 5,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "shop-create",
                    Title = "Thêm cửa hàng"
                },
                new Permission()
                {
                    Id=6,   
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "shop-update",
                    Title = "Sửa cửa hàng"
                },
                new Permission()
                {
                    Id=7,   
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "shop-delete",
                    Title = "Xóa cửa hàng"
                },
                new Permission()
                {
                    Id=8,   
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "shop-get",
                    Title = "Xem cửa hàng"
                }
             );

            //permission for app
            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id=9,   
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "app-update",
                    Title = "Sửa thông tin ứng dụng"
                },
                new Permission()
                {
                    Id =10,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "app-get",
                    Title = "Xem thông tin ứng dụng"
                }
            );

            //permission for account
            modelBuilder.Entity<Permission>().HasData(
                 new Permission()
                 {
                     Id=11, 
                     Created = DateTime.Now,
                     IsDelete = false,
                     LastModified = DateTime.Now,
                     Key = "account-create",
                     Title = "Thêm tài khoản"
                 },
                 new Permission()
                 {
                     Id=12, 
                     Created = DateTime.Now,
                     IsDelete = false,
                     LastModified = DateTime.Now,
                     Key = "account-update",
                     Title = "Sửa tài khoản"
                 },
                 new Permission()
                 {
                     Id=13, 
                     Created = DateTime.Now,
                     IsDelete = false,
                     LastModified = DateTime.Now,
                     Key = "account-delete",
                     Title = "Xóa tài khoản"
                 },
                 new Permission()
                 {
                     Id=14, 
                     Created = DateTime.Now,
                     IsDelete = false,
                     LastModified = DateTime.Now,
                     Key = "account-get",
                     Title = "Xem tài khoản"
                 }
            );

            //permission for role
            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id=15,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "role-create",
                    Title = "Thêm nhóm quyền"
                },
                new Permission()
                {
                    Id =16, 
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "role-update",
                    Title = "Sửa nhóm quyền"
                },
                new Permission()
                {
                    Id=17,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "role-delete",
                    Title = "Xóa nhóm quyền"
                },
                new Permission()
                {
                    Id=18,
                    Created = DateTime.Now,
                    IsDelete = false,
                    LastModified = DateTime.Now,
                    Key = "role-get",
                    Title = "Xem nhóm quyền"
                }
             );
        }
    }
}
