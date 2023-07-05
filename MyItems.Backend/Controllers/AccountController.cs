using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyItems.Backend.Dto;
using MyItems.Backend.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MyItems.Backend.Service;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<LoginDto> _passwordHasher;
        private readonly AccountService _accountService;

        public AccountController(
            AppDbContext context, 
            IPasswordHasher<LoginDto> passwordHasher,
            AccountService accountService)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _accountService = accountService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] LoginDto model)
        {
            var result = await _accountService.Register(model);

            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody]LoginDto model)
        {
            if (model is null
                || model.Email is null
                || model.Password is null
                || model.Email == string.Empty 
                || model.Password == string.Empty)
                return BadRequest();

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == model.Email);

            if (user is null)
                return NotFound("Email does not exist");

            var passwordHash = _passwordHasher.VerifyHashedPassword(model, user.PasswordHash, model.Password);

            if (passwordHash == PasswordVerificationResult.Failed)
                return Unauthorized("Email or Password does not exist!");

            var claims = new List<Claim>()
            { 
                new Claim(ClaimTypes.Name, model.Email) 
            };

            if (user.IsAdmin)
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            else
                claims.Add(new Claim(ClaimTypes.Role, "User"));
            
            var token = new JwtSecurityToken(
                issuer: JwtData.ISSUER,
                audience: JwtData.AUDIENCE,
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: new SigningCredentials(
                    JwtData.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(encodedToken);
        }
    }
}
