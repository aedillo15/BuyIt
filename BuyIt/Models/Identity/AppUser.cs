using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyIt.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace BuyIt.Models.Identity
{

    public class AppUser : IdentityUser
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public List<Product> Products = new List<Product>();
        
    }
}