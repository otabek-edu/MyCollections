using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyItems.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;


namespace MyItems.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminTestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdminTestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("users/{userId}")]
        public IActionResult GetUserById(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("users/block/{userId}")]
        public IActionResult BlockUser(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }

            user.IsBlocked = true;
            _context.SaveChanges();

            return Ok("User has been blocked.");
        }

        [HttpPost("users/unblock/{userId}")]
        public IActionResult UnblockUser(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }

            user.IsBlocked = false;
            _context.SaveChanges();

            return Ok("User has been unblocked.");
        }

        [HttpPost("users/{userId}/admin")]
        public IActionResult AddAdminRights(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }

            user.IsAdmin = true;
            _context.SaveChanges();

            return Ok("Admin rights added to the user.");
        }

        [HttpDelete("users/{userId}/admin")]
        public IActionResult RemoveAdminRights(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }

            user.IsAdmin = false;
            _context.SaveChanges();

            return Ok("Admin rights removed from the user.");
        }
    }
}
