using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.BusinessLogic.Interface;
using WebShop.DataAccess.Entities;
using WebShop.DataAccess.Interfaces;

namespace WebShop.BusinessLogic.Servises
{
    public class BookService : IBookservice
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }
       public async Task<IEnumerable<Book>> Get()
        {
            return await _repository.Get();
            
        }
        public async Task<Book> GetById(string id)
        {
            return await _repository.GetById(id);
        }
        public async Task<Book> Add(Book book)
        {
            return await _repository.Add(book);
        }
        public async Task<Book> Update(Book book)
        {
            return await _repository.Update();
        }
        public async Task<bool> Delete(string id)
        {
            return await _repository.Delete(id);
        }

    }
}
