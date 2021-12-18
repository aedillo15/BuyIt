using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyIt.Models.Entities
{
public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price {get; set;}
        public User User {get; set;}

    }
}