using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.DataAccess.Context;
using WebShop.DataAccess.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        ApplicationContext ibookservice;

        // GET: /<controller>/
        public BookController(ApplicationContext context)
        {
           ibookservice = context;
            if (!ibookservice.Books.Any())
            {
                ibookservice.Books.Add(new Book { Name = "С#", Author = "Пушкин", Price = 200, Year = 1998 });
                ibookservice.Books.Add(new Book { Name = " Красная шапочка", Author = "Петрович", Price = 21000, Year = 1995 });
                ibookservice.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return ibookservice.Books.ToList();
           
        }
        // POST 
        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book == null)
            {
                ModelState.AddModelError("", "Не указаны данные для книги");
                return BadRequest(ModelState);
            }
            // обработка частных случаев валидации
            if (book.Name == "admin")
            {
                ModelState.AddModelError("Name", "Недопустимое имя пользователя - admin");
            }
            // если есть лшибки - возвращаем ошибку 400
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // если ошибок нет, сохраняем в базу данных
            ibookservice.Books.Add(book);
            ibookservice.SaveChanges();
            return Ok(book);
        }
        
    }
}

