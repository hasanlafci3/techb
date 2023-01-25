using Microsoft.EntityFrameworkCore;
using Techb.Data.Model;

namespace Techb.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // db set 
        public DbSet<Account> Account { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Store> Store { get; set; }


    }
}
