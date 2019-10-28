using WEBSHOPDATAACSSESLEAR.Entities.Base;

namespace WebShopDataAccesLear
{
  public  class Book : BaseEntity
    {
 
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
  
    }
}
