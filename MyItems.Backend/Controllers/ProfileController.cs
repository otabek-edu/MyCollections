using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyItems.Backend.Results;
using MyItems.Backend.Services;
using System.Security.Claims;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileService _profileService;

        public ProfileController(ProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfileForAdmin(Guid id)
        {
            var user = await _profileService.GetUser(id);
            return Ok(user);
        }

        [HttpGet("my")]
        [Authorize]
        public async Task<IActionResult> GetProfile()
        {
            Guid userId = Guid.Empty;
            if (Guid.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userId))
            {
                var result = await _profileService.GetUser(userId);
                return Ok(result);
            }

            return Ok(new ErrorResult("Not found!"));
        }
    }
}
