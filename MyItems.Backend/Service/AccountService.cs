using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dto;
using MyItems.Backend.Models;
using MyItems.Backend.Exceptions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyItems.Backend.Service
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

        public async Task<string> Register(LoginDto model)
        {
            if (model is null
                || model.Email is null
                || model.Password is null)
                throw new Exceptions.InvalidDataException("Invalid data!");

            var emailValidation = new EmailAddressAttribute().IsValid(model.Email);

            if (!emailValidation)
                throw new Exceptions.InvalidEmailException("Invalid Email!");

            var emailExist = await _context.Users
                .Where(x => x.Email == model.Email)
                .ToListAsync();

            if (emailExist.Count >= 1)
                throw new InvalidEmailException("Email already exist");

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
        }

        
    }

    public class SuccessDataResult<T> : Exception
    {
        public static IActionResult BadRequest()
        {
            return new BadRequestResult();
        }

        public static IActionResult Conflict(string message)
        {
            return new ConflictObjectResult(message);
        }

        public static IActionResult NotFound()
        {
            return new NotFoundResult();
        }

        public static IActionResult Unauthorized()
        {
            return new UnauthorizedResult();
        }
    }
}
