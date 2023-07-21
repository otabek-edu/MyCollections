using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Korzh.EasyQuery.Linq;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{query}")]
        public IActionResult Search(string query)
        {
            var fullResult = _context.Collections
                .FullTextSearchQuery(query);

            return Ok(fullResult);
        }
    }
}
