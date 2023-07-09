using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using MyItems.Backend.Results;
using MyItems.Backend.ViewModel;
using System.ComponentModel.DataAnnotations;
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

        private bool ValidateData(LoginDto model)
        {
            if (model is null
                || model.Email == string.Empty
                || model.Password == string.Empty)
                return false;
            return true;
        }

        private bool EmailValidation(string email)
        {
            var emailValidation = new EmailAddressAttribute().IsValid(email);
            if (!emailValidation)
                return false;
            return true;
        }

        private async Task<bool> EmailExistValidation(string email)
        {
            var emailExist = await _context.Users
                .Where(x => x.Email == email)
                .ToListAsync();

            if (emailExist.Count >= 1)
                return false;
            return true;
        }

        private async Task CreateAccount(RegisterDto model)
        {
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
        }

        private async Task<User> GetUserByEmail(string email)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == email);

            return user;
        }

        private bool PasswordVerification(LoginDto model, string passwordHash)
        {
            var passwordVerification = _passwordHasher.VerifyHashedPassword(model, passwordHash, model.Password);
            if (passwordVerification == PasswordVerificationResult.Failed)
                return false;
            return true;
        }

        private string GenerateToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Email)
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
            return encodedToken;
        }

        public async Task<Result> Register(RegisterDto model)
        {
            if (!ValidateData(model))
                return new ErrorResult("Invalid Email!");

            if (model.FirstName == string.Empty || model.LastName == string.Empty)
                return new ErrorResult("Invalid Name!");

            if (!EmailValidation(model.Email))
                return new ErrorResult("Invalid Email!");

            if (!(await EmailExistValidation(model.Email)))
                return new ErrorResult("Email already exist");

            await CreateAccount(model);
            return new SuccessResult("Account created!");
        }

        public async Task<Result> Login(LoginDto model)
        {
            if (!ValidateData(model))
                return new ErrorResult("Invalid data!");

            var user = await GetUserByEmail(model.Email);

            if (user is null)
                return new ErrorResult("Email does not exist");

            if (!PasswordVerification(model, user.PasswordHash))
                return new ErrorResult("Email or Password does not exist!");

            var token = GenerateToken(user);
            return new SuccessResult(token);
        }
    }
}
