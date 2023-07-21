using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Korzh.EasyQuery.Linq;
using MyItems.Backend.ViewModel;

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
            var searchResultCollections = _context.Collections
                .FullTextSearchQuery(query)
                .Select(x => new CollectionViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    ItemsCount = x.Items.Count
                }).ToList();

            var searchResultItems = _context.Items
                .FullTextSearchQuery(query)
                .Select(x => new ItemViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();

            var fullResult = new SearchResultViewModel()
            {
                Collections = searchResultCollections,
                Items = searchResultItems
            };

            return Ok(fullResult);
        }
    }
}
