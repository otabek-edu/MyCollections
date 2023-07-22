using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Results;
using MyItems.Backend.ViewModel;

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
                .Select(c => new CollectionViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ItemsCount = c.Items.Count
                })
                .ToListAsync();

            return new SuccessDataResult<List<CollectionViewModel>>(topCollections);
        }

        public async Task<Result> GetRecentItems()
        {
            var recentItems = await _context.Items
                .Include(i => i.Collection)
                .OrderByDescending(i => i.CreatedAt)
                .Take(15)
                .Select(i => new ItemViewModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    CollectionId = i.Collection.Id,
                    CollectionName = i.Collection.Name,
                    AuthorId = i.Collection.User.Id,
                    Author = i.Collection.User.FirstName + " " + i.Collection.User.LastName
                })
                .ToListAsync();

            return new SuccessDataResult<List<ItemViewModel>>(recentItems);
        }

        public async Task<Result> SearchCollections(string query)
        {
            var collections = await _context.Collections
                .Include(x => x.Items)
                    .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                .Where(x => x.Name.Contains(query)
                || x.Description.Contains(query)
                || x.Items.Any(item => item.Name.Contains(query)
                ||item.CustomPropertyValues.Any(cpValue => cpValue.Value.Contains(query))))
                .ToListAsync();

            return new SuccessDataResult<List<Collection>>(collections);
        }
    }
}
