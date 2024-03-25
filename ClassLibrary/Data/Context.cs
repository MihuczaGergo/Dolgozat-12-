using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class Context : DbContext
    {
        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* MsSQl:
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=EmberekDb;Trusted_Connection=True");
            */
            string myConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=EmberekDb";
            optionsBuilder.UseMySql(myConnectionString, ServerVersion.AutoDetect(myConnectionString));
        }
        public DbSet<Alkalmazottak> Alkalmazottak { get; set; }
    }
}