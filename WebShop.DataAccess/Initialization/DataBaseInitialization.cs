using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace WebShop.DataAccess.Initialization
{
    public class DataBaseInitialization
    {
        public static void Initialize(ApplicationContext context)
        {
            if (context.Books.Any())
            {         
                return;   // DB has been seeded
            }
            var Books = new Book[]
            {
                new Book{ Name = "Carson",   Author = "Alexander", Price = 520, Year = 1998 },
                new Book{ Name = "Carson",   Author = "Alexander", Price = 520, Year = 1998 },
                new Book{ Name = "Carson",   Author = "Alexander", Price = 520, Year = 1998 }
            };

            foreach (Book b in Books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
        }
    }
}
