using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MyItems.Backend.Results;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MyItems.Backend.Services
{
    public class AccountService
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<LoginDto> _passwordHasher;

        public AccountService(AppDbContext context, IPasswordHasher<LoginDto> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<Result> Register(RegisterDto model)
        {
            if (model is null
                || model.Email is null
                || model.Password is null)
                return new ErrorResult("Invalid data!");

            var emailValidation = new EmailAddressAttribute().IsValid(model.Email);

            if (!emailValidation)
                return new ErrorResult("Invalid Email!");

            var emailExist = await _context.Users
                .Where(x => x.Email == model.Email)
                .ToListAsync();

            if (emailExist.Count >= 1)
                return new ErrorResult("Email already exist");

            var passwordHash = _passwordHasher.HashPassword(model, model.Password);

            var userUuid = Guid.NewGuid();

            await _context.Users.AddAsync(new User
            {
                Id = userUuid,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordHash = passwordHash,
                IsAdmin = false,
                IsBlocked = false
            });

            await _context.SaveChangesAsync();

            return new SuccessResult("Account created!");
        }

        public async Task<Result> Login(LoginDto model)
        {
            if (model is null
                || model.Email is null
                || model.Password is null
                || model.Email == string.Empty
                || model.Password == string.Empty)
                return new ErrorResult("Invalid data!");

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == model.Email);

            if (user is null)
                return new ErrorResult("Email does not exist");

            var passwordHash = _passwordHasher.VerifyHashedPassword(model, user.PasswordHash, model.Password);

            if (passwordHash == PasswordVerificationResult.Failed)
                return new ErrorResult("Email or Password does not exist!");

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

            return new SuccessResult(encodedToken);
        }
    }
}
