using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Results;

namespace MyItems.Backend.Services
{
    public class ProfileService
    {
        private readonly AppDbContext _context;

        public ProfileService(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<Result> GetUser(Guid id)
        {
            var user = await _context.Users
                .Include(c => c.Collections)
                .FirstOrDefaultAsync(u => u.Id == id);
            
            if (user == null)
                return new ErrorResult("User not found");

            return new SuccessDataResult<User>(user);
        }
    }
}
