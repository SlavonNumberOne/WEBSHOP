using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.BusinessLogic.Interface
{
    public interface IBookservice
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(string id);
        Task<Book> Add(Book book);
        Book Update(Book book);
        bool Delete(string id);

    }
}
