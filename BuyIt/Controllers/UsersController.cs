using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuyIt.Models;
using BuyIt.Models.DTO;
using BuyIt.Models.Entities;
using BuyIt.Models.Persistence;
using BuyIt.Models.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BuyIt.Controllers
{
    [Route("BuyIt/[controller]")]
    public class UsersController : ControllerBase
    {
        //todo: inject the userContext
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        
        // [HttpPost("SignUp")] // POST : /Users/SignUp
        // public async Task<IActionResult> Post([FromBody] SignUpDto signUpDto)
        // {
            
        //     return("hello");
        // }

        // [HttpPost("Login")] // GET : /Users/Login
        // public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        // {
        //     return("hello");
        // }
        
    }
}