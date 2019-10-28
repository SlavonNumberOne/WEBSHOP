using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDataAccesLear;

namespace WEBSHOPDATAACSSESLEAR.Entities
{
    public class OrderItem
    {
        public Book Book { get; set; }
        public Order Order { get; set; }
        public int Count { get; set; }//количество
    } 
}
