using BuyIt.Models.Entities;
using BuyIt.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuyIt.Models.Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public override DbSet<User> Users { get; set; }
        public override DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
    }
}