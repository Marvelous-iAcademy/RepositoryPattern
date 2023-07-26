using Microsoft.EntityFrameworkCore;
using ReposittoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=your_database.db");
        }
    }

    
}
