using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuyIt.Models;
using BuyIt.Models.DTO;
using BuyIt.Models.Entities;
using BuyIt.Models.Identity;
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
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly TokenService _tokenService;
        //todo: inject the userContext
        public UsersController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            TokenService tokenService

            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }
        
        [HttpPost("SignUp")] // POST : /Users/SignUp
        public async Task<IActionResult> Post([FromBody] SignUpDto signUpDto)
        {
            var result = await _userManager.CreateAsync(new AppUser
            {
                Email = signUpDto.Email,
                UserName = signUpDto.UserName
            }, signUpDto.Password);

            if (result.Succeeded)
                return Ok();

            return BadRequest(result.Errors);

        }

        [HttpPost("Login")] // GET : /Users/Login
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
                return Unauthorized();


            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);


            if (!result.Succeeded)
                return Unauthorized();

            return Ok(new UserDto
            {
                Token = _tokenService.CreateToken(user)
            });

        }
        
    }
}