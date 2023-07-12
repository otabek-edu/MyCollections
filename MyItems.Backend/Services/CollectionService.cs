using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using MyItems.Backend.Results;

namespace MyItems.Backend.Services
{
    public class CollectionService
    {
        private readonly AppDbContext _context;

        public CollectionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetCollection(Guid id)
        {
            var collection = await _context.Collections
                .Include(x => x.Items)
                    .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (collection == null)
                return new ErrorResult("Collection not found");

            return new SuccessDataResult<Collection>(collection);
        }

        public async Task<Result> CreateCollection(CollectionDto model, Guid userId)
        {
            var collection = new Collection
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                Theme = model.Theme,
                ImageUrl = model.ImageUrl,
                UserId = userId
            };

            await _context.Collections.AddAsync(collection);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> UpdateCollection(Collection collection)
        {
            _context.Collections.Update(collection);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> DeleteCollection(Guid id)
        {
            var collection = await _context.Collections
                .FirstOrDefaultAsync(x => x.Id == id);

            if (collection == null)
                return new ErrorResult("Collection not found");

            _context.Collections.Remove(collection);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> GetItem(Guid id)
        {
            var item = await _context.Items
                .Include(x => x.CustomPropertyValues)
                    .ThenInclude(x => x.CustomProperty)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return new ErrorResult("Item not found");

            return new SuccessDataResult<Item>(item);
        }
    }
}
