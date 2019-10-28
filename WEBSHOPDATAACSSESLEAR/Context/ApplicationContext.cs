using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebShopDataAccesLear;
using WEBSHOPDATAACSSESLEAR.Entities;



namespace WEBSHOPDATAACSSESLEAR.Context
{
    public class ApplicationContext: IdentityDbContext<User>
    {
     
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base (options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
