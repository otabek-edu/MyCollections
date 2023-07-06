using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Results;

namespace MyItems.Backend.Services
{
    public class AdminService
    {
        private readonly AppDbContext _context;

        public AdminService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();

            return new SuccessDataResult<List<User>>(users);
        }

        public async Task<Result> BlockUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return new ErrorResult("User not found");
            }

            user.IsBlocked = true;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> UnBlockUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return new ErrorResult("User not found");
            }

            user.IsBlocked = false;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> SetAdmin(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return new ErrorResult("User not found");
            }

            user.IsAdmin = true;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> UnSetAdmin(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return new ErrorResult("User not found");
            }

            user.IsAdmin = false;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task<Result> DeleteUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return new ErrorResult("User not found");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return new SuccessResult();
        }
    }
}
