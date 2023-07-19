using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Results;
using MyItems.Backend.ViewModel;

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
            var userViewModel = await _context.Users
                .Where(u => u.Id == id)
                .Select(u => new UserViewModel
                {
                    Id = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Collections = u.Collections.Select(c => new CollectionViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description,
                        ItemsCount = c.Items.Count,
                        Theme = c.Theme,
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (userViewModel == null)
                return new ErrorResult("User not found");

            return new SuccessDataResult<UserViewModel>(userViewModel);
        }
    }
}
