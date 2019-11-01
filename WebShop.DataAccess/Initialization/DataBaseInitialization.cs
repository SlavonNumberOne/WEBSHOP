﻿using System;
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
        private readonly ApplicationContext _context;

        public DataBaseInitialization(ApplicationContext context)
        {
            _context = context;
        }
        public void Initialize()
        {
            if (_context.Books.Any())
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
                _context.Books.Add(b);
            }
            _context.SaveChanges();
        }
    }
}
