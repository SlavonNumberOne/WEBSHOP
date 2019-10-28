using WEBSHOPDATAACSSESLEAR.Entities.Base;

namespace WEBSHOPDATAACSSESLEAR.Entities
{
  public  class Author : BaseEntity
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public int Year { get; set; }
    }
}
