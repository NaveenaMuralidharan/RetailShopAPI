using Retail.Repository.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using Retail.Repositories.EntityModels;

namespace Retail.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> OrderProducts { get; set; }
    }



}
