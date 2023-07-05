using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyItems.Backend.Dtos;
using MyItems.Backend.Services;
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
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var result = await _accountService.Register(model);

            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var result = await _accountService.Login(model);

            return Ok(result);
        }
    }
}
