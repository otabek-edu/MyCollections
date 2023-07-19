using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using MyItems.Backend.Results;
using MyItems.Backend.ViewModel;

namespace MyItems.Backend.Services
{
    public class CollectionService
    {
        private readonly AppDbContext _context;

        public CollectionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetCollectionById(Guid id)
        {
            var collection = await _context.Collections
                .Include(x => x.Items)
                    .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                .Select(c => new CollectionViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ItemsCount = c.Items.Count,
                    Theme = c.Theme,
                    CustomProperties = c.CustomProperties,
                    ImageUrl = c.ImageUrl,
                    UserId = c.UserId,
                    Author = c.User.FirstName + " " + c.User.LastName,
                    Items = c.Items
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (collection == null)
                return new ErrorResult("Collection not found");

            return new SuccessDataResult<CollectionViewModel>(collection);
        }

        public async Task<Result> GetCollectionsByUserId(Guid userId)
        {
            var collections = await _context.Collections
                .Include(x => x.Items)
                    .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                .Select(c => new CollectionViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ItemsCount = c.Items.Count,
                    Theme = c.Theme,
                    ImageUrl = c.ImageUrl,
                    UserId = c.UserId,
                    Author = c.User.FirstName + " " + c.User.LastName,
                    Items = c.Items,
                    CustomProperties = c.CustomProperties
                })
                .Where(x => x.UserId == userId)
                .ToListAsync();

            if (collections == null)
                return new ErrorResult("Collections not found");

            return new SuccessDataResult<List<CollectionViewModel>>(collections);
        }


        public async Task<Result> GetCollections()
        {
            var collections = await _context.Collections
                .Take(5)
                .ToListAsync();

            if (collections is null)
                return new ErrorResult("Collections not found");

            return new SuccessDataResult<List<Collection>>(collections);
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
    }
}
