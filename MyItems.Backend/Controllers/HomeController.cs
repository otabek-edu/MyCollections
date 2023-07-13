using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Services;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("top")]
        public async Task<IActionResult> GetCollections()
        {
            var collections = await _homeService.GetTopCollections();

            return Ok(collections);
        }

        [HttpGet("recent")]
        public async Task<IActionResult> GetRecentItems()
        {
            var recentItems = await _homeService.GetRecentItems();

            return Ok(recentItems);
        }

        [HttpGet("search/{query}")]
        public async Task<IActionResult> SearchCollections(string query)
        {
            var collections = await _homeService.SearchCollections(query);

            return Ok(collections);
        }
    }
}
