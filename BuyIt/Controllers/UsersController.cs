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

        
        [HttpPost("register")] // POST : /Users/SignUp
        public async Task<IActionResult> RegisterUser([FromBody] SignUpDto signUpDto)
        {
             if (string.IsNullOrEmpty(signUpDto.Email))
                return BadRequest();   
            else if (string.IsNullOrEmpty(signUpDto.Password))
                return BadRequest();   
            else if (string.IsNullOrEmpty(signUpDto.UserName))
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

        [HttpPost("products")] // POST : /Users/SignUp
        public async Task<IActionResult> AddProducts([FromBody] ProductDto productDto)
        {
             if (string.IsNullOrEmpty(productDto.Name))
                return BadRequest();   
            else if (string.IsNullOrEmpty(productDto.Price))
                return BadRequest();    

                 var product = new Product{
                     Name = productDto.Name,
                     Price = productDto.Price
                };


              await _context.Products.AddAsync(product);
             await _context.SaveChangesAsync();

             return Ok();
        }
        [HttpGet("products")] // GET 
        public async Task<IActionResult> GetProducts()
        {
             return Ok(_context.Products);
        }

         [HttpPost("login")] // POST : /Users/Login
         public async Task<IActionResult> LoginUser([FromBody] LoginDto loginDto)
         {
                if (string.IsNullOrEmpty(loginDto.Email))
                return BadRequest();
                else if (string.IsNullOrEmpty(loginDto.Password))
                return BadRequest();

                var user = await _context.Users
                                    .SingleOrDefaultAsync(x =>x.Email == loginDto.Email);

                if(user.Password == loginDto.Password){
                    return Ok(user.Email);
                }              
                else{
                    return BadRequest();
                }      
         }
        
    }
}