using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly AppDbContext _context;

        public Home(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IList Get()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}
