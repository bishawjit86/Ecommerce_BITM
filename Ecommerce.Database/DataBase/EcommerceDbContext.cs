using Ecommerce.Models;
using Ecommerce.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.DataBase
{
    public class EcommerceDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> GetCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "Server = DESKTOP-9E8DD3G\\SQLEXPRESS;DataBase=EcommerceDb06;Integrated Security = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
