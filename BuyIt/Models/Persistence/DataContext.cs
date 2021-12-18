using BuyIt.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuyIt.Models.Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public  DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=people.db");
        }
    }
        
}
