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
                Id = 1,
                Created = DateTime.Now,
                IsDelete = false,
                LastModified = DateTime.Now,
                Password = "123456789",
                UserName = "superadmin",
                Role = (int)RoleEnum.SuperAdmin
            };
            accounts.Add(superAdmin);

            modelBuilder.Entity<Account>().HasData(accounts);
        }


    }
}
