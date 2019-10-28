using WebShopDataAccesLear;
using WEBSHOPDATAACSSESLEAR.Entities.Base;

namespace WEBSHOPDATAACSSESLEAR.Entities
{
   public class UserRole: BaseEntity
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
