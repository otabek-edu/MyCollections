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

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<LoginDto> _passwordHasher;

        public AccountController(AppDbContext context, IPasswordHasher<LoginDto> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] LoginDto model)
        {
            if (model is null 
                || model.Email is null 
                || model.Password is null)
                return BadRequest();

            var emailValidation = new EmailAddressAttribute().IsValid(model.Email);

            if (!emailValidation)
                return BadRequest();

            var emailExist = await _context.Users
                .Where(x => x.Email == model.Email)
                .ToListAsync();

            if (emailExist.Count >= 1)
                return Conflict("Email exist");

            var passwordHash = _passwordHasher.HashPassword(model, model.Password);

            var userUuid = Guid.NewGuid();

            await _context.Users.AddAsync(new User
            {
                Id = userUuid,
                FirstName = "FirstName",
                LastName = "LastName",
                Email = model.Email,
                PasswordHash = passwordHash,
                IsAdmin = false,
                IsBlocked = false
            });

            await _context.SaveChangesAsync();

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
                return NotFound();

            var passwordHash = _passwordHasher.VerifyHashedPassword(model, user.PasswordHash, model.Password);

            if (passwordHash == PasswordVerificationResult.Failed)
                return Unauthorized();

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
