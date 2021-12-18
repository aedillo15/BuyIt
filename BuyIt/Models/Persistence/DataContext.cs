using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyIt.Models.Entities;
using BuyIt.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuyIt.Models.Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=users.db");
        }
        
    }
}