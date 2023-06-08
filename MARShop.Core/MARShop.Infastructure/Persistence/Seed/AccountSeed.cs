using BCrypt.Net;
using MARShop.Core.Entities;
using MARShop.Core.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MARShop.Infastructure.Persistence.Seed
{
    public static class AccountSeed
    {
        public static void SeedAccount(this ModelBuilder modelBuilder)
        {
            IList<Account> accounts = new List<Account>();

            var superAdmin = new Account()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "superadmin",
                Password = BCrypt.Net.BCrypt.HashPassword("admin@123"),
                Role= nameof(Role.Admin),
                Created = DateTime.Now,
                IsDelete = false,
                LastModified = DateTime.Now,
            };
            accounts.Add(superAdmin);

            modelBuilder.Entity<Account>().HasData(accounts);
        }


    }
}
