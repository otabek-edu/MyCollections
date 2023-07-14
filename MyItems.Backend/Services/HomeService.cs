using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Results;

namespace MyItems.Backend.Services
{
    public class HomeService
    {

        private readonly AppDbContext _context;

        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetTopCollections()
        {
            var topCollections = await _context.Collections
                .Include(c => c.Items)
                .OrderByDescending(c => c.Items.Count)
                .Take(5)
                .ToListAsync();

            return new SuccessDataResult<List<Collection>>(topCollections);
        }

        public async Task<Result> GetRecentItems()
        {
            var recentItems = await _context.Items
                .Include(i => i.Collection)
                .OrderByDescending(i => i.CreatedAt)
                .Take(5)
                .ToListAsync();

            return new SuccessDataResult<List<Item>>(recentItems);
        }

        public async Task<Result> SearchCollections(string query)
        {
            var collections = await _context.Collections
                .Include(x => x.Items)
                    .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                .Where(x => x.Name.Contains(query))
                .ToListAsync();

            return new SuccessDataResult<List<Collection>>(collections);
        }
    }
}
