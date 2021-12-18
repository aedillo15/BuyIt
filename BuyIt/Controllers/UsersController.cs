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
    [Route("buyit/[controller]")]
    public class UsersController : ControllerBase
    {
        //todo: inject the userContext
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        
        [HttpPost] // POST : /Users/SignUp
        public async Task<IActionResult> RegisterUser([FromBody] SignUpDto signUpDto)
        {
            
             if (string.IsNullOrEmpty(signUpDto.Email))
                return BadRequest();

                 var user = new User{
                     Email = signUpDto.Email,
                     Name = signUpDto.UserName,
                     Password = signUpDto.Password
                };


              await _context.Users.AddAsync(user);
             await _context.SaveChangesAsync();

             return Ok();
        }

        // [HttpPost("Login")] // GET : /Users/Login
        // public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        // {
        //     return("hello");
        // }
        
    }
}