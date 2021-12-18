using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuyIt.Models;
using BuyIt.Models.DTO;
//using BuyIt.Models.DTOs;
using BuyIt.Models.Entities;
using BuyIt.Models.Responses;
//using API.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BuyIt.Entities.Controllers
{
    [Route("BuyIt/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;
        //todo: inject the userContext
        public UsersController(UserContext context)
        {
            _context = context;
        }

        [HttpPost] 
        public async Task<IActionResult> CreateUser (User user)
        {
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        //GET /BuyIt/Users/{id}
        [HttpGet("{id}")]
        // [Route("{id}")]
        // [Route("getPerson/{id}")]
        public async Task<IActionResult> GetUser(string emailAddress, string password)
        {
            try
            {
                var user = await _context.users.FindAsync();
                // var list = new List<Person>();
                // var response = 

                if (user == null)
                    return NotFound();
                var personDto = new PersonDto
                {
                    Id = user.Id,
                    Email = user.Email
                };

                return Ok(new Response<PersonDto>(personDto));
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        //POST : /BuyIt/
        [HttpPost]
        public async Task<IActionResult> PostArray([FromBody] User[] data)
        {
            await _context.users.AddRangeAsync(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}