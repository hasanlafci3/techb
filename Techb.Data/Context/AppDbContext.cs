using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
