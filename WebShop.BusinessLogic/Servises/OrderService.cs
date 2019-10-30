using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess.EFRepositories;
using WebShop.DataAccess.Entities;
using WebShop.DataAccess.Interfaces;

namespace WebShop.BusinessLogic.Servises
{
   public class OrderService : IOrderService
    {
        private readonly OrderRepository _ordrepository;

        public OrderService(IOrderRepository ordrepository)
        {
            _ordrepository = ordrepository;
        }
        public async Task<IEnumerable<Order>> Get()
        {
            return await _ordrepository.Get();
        }
        public Task<Order> GetById(string id)
        {

        }
        public Task<Order> Add(Order order)
        {

        }
        public Order Update(Order order)
        {

        }
        bool Delete(string id)
        {

        }
    }
}
