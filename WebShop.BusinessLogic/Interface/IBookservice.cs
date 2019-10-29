using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities;

namespace WebShop.BusinessLogic.Interface
{
    public interface IBookservice
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(string id);
        Task<Book> Add(Book book);
        Task<Book> Update(Book book);
        Task<bool> Delete(string id);

    }
}
