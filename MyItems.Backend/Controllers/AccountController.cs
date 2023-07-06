using Microsoft.AspNetCore.Mvc;
using MyItems.Backend.Dtos;
using MyItems.Backend.Services;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
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
