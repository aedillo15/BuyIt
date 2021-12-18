using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyIt.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password {get; set;}
        public string Name { get; set; }

        public List<Product> Products {get; set;}

    }
}