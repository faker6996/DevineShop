using MARShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MARShop.Infastructure.Persistence.Seed
{
    public static class ContactSeed
    {
        public static void SeedContact(this ModelBuilder modelBuilder)
        {
            IList<Contact> contacts = new List<Contact>();

            var onlyFirstContact = new Contact()
            {
                Id = Guid.NewGuid().ToString(),
                Created = DateTime.Now,
                IsDelete = false,
                LastModified = DateTime.Now,
                Facebook = "",
                Linkedin = "",
                Email= "",
                Zalo= "",
            };

            contacts.Add(onlyFirstContact);

            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}
