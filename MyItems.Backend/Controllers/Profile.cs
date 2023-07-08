using Microsoft.AspNetCore.Mvc;
using MyItems.Backend.Results;
using MyItems.Backend.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Profile : ControllerBase
    {
        private readonly ProfileService _profileService;

        public Profile(ProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _profileService.GetUser(id);
            
            return Ok(result);
        }
    }
}
