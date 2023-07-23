using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.Services;
using System.Security.Claims;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _adminService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("users/{userId}")]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            var user = await _adminService.GetUserById(userId);
            return Ok(user);
        }

        [HttpPost("users/block/{userId}")]
        public async Task<IActionResult> BlockUser(Guid userId)
        {
            var result = await _adminService.BlockUser(userId);
            return Ok(result);
        }

        [HttpPost("users/unBlock/{userId}")]
        public async Task<IActionResult> UnBlockUser(Guid userId)
        {
            var result = await _adminService.UnBlockUser(userId);
            return Ok(result);
        }

        [HttpPost("users/setAdmin/{userId}")]
        public async Task<IActionResult> SetAdmin(Guid userId)
        {
            var result = await _adminService.SetAdmin(userId);
            return Ok(result);
        }

        [HttpPost("users/unSetAdmin/{userId}")]
        public async Task<IActionResult> UnSetAdmin(Guid userId)
        {
            var result = await _adminService.UnSetAdmin(userId);
            return Ok(result);
        }

        [HttpDelete("users/{userId}")]
        public async Task<IActionResult> DeleteUser(Guid userId)
        {
            var result = await _adminService.DeleteUser(userId);
            return Ok(result);
        }
    }
}
