using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Entities;

namespace WebShop.DataAccess.Initialization
{
    public class DataDaseInitialization
    {
        public static void Initialize(ApplicationContext context)
        {
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Name = "Мишкин дом",
                        Author ="Фредрик Бакман",
                        Price = 220,
                        Year = 2016
                     },
                      new Book
                      {
                          Name = "Солнце",
                          Author = "Борис Гурский",
                          Price = 10000,
                          Year = 1889
                      },
                       new Book
                       {
                           Name = "Основы програмирования C# ",
                           Author = "Станислав Окулов",
                           Price = 458,
                           Year = 2005
                       }
                    );
                context.SaveChanges();
            }
        }
    }
}
