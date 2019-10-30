using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.BusinessLogic.Interface
{
  public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthor();
        //Task<Author> GetById(string id);
        Task<Author> AddAuthor(Author author);
        Author UpdateAuthor(Author author);
        bool DeleteAuthor(string id); 
    }
}
