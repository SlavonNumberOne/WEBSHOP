using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDataAccesLear;
using WEBSHOPDATAACSSESLEAR.Entities.Base;

namespace WEBSHOPDATAACSSESLEAR.Entities
{
  public  class Order: BaseEntity
    {
        public User User  { get; set; }
        public string Paid { get; set; } // оплата
        public string Delivery { get; set; }//достиавка
        public string Comment { get; set; }//комментарий
    }
}

