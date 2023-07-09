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

        public async Task<Result> GetCollections()
        {
            var collections = await _context.Users
                .Include(c => c.Collections)
                    .ThenInclude(x => x.Items)
                        .ThenInclude(x => x.CustomPropertyValues)
                        .ThenInclude(x => x.CustomProperty)
                    
                .ToListAsync();

            return new SuccessDataResult<List<User>>(collections);
        }
    }
}
