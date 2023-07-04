using Microsoft.AspNetCore.Identity;

namespace MyItems.Backend.Service
{
    public class AccountService
    {
        private readonly MyItemsContext _context;
        private readonly IPasswordHasher _passwordHasher;

        public AccountService(AppDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<AccountResponse> RegisterAsync(RegisterRequest model)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(x => x.Email == model.Email);

            if (account != null)
            {
                throw new AppException("Email already exists");
            }

            account = new Account
            {
                Id = Guid.NewGuid(),
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PasswordHash = _passwordHasher.Hash(model.Password)
            };

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return new AccountResponse(account);
        }

        public async Task<AccountResponse> AuthenticateAsync(AuthenticateRequest model)
        {
            var account = await _context.Accounts.SingleOrDefaultAsync(x => x.Email == model.Email);

            if (account == null || !_passwordHasher.Verify(model.Password, account.PasswordHash))
            {
                throw new AppException("Email or password is incorrect");
            }

            var response = new AccountResponse(account);
            response.Token = _tokenService.GenerateToken(account);

            return response;
        }

        public async Task<IEnumerable<AccountResponse>> GetAllAsync()
        {
            var accounts = await _context.Accounts.ToListAsync();

            return accounts.Select(x => new AccountResponse(x));
        }

        public async Task<AccountResponse> GetByIdAsync(Guid id)
        {
            var account = await _context.Accounts.FindAsync(id);

            return new AccountResponse(account);
        }

        public async Task<AccountResponse> UpdateAsync(Guid id, UpdateRequest model)
        {
            var account = await _context.Accounts.FindAsync(id);

            if (account == null)
            {
                throw new KeyNotFoundException("Account not found");
            }

            if (model.Email != account.Email && await _context.Accounts.AnyAsync(x => x.Email == model.Email))
            {
                throw new AppException($"Email '{model.Email}' is already taken");
            }

            account.FirstName = model.FirstName;
            account.LastName = model.LastName;
            account.Email = model.Email;

            if (!string.IsNullOrWhiteSpace(model.Password))
        }
    }
}
