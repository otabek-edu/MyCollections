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
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly AdminService _adminService;

        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _adminService.GetAllUsers();
            return Ok(users);
        }

        [HttpPut]
        [Route("BlockUser")]
        public async Task<IActionResult> BlockUser(Guid id)
        {
            var result = await _adminService.BlockUser(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("UnBlockUser")]
        public async Task<IActionResult> UnBlockUser(Guid id)
        {
            var result = await _adminService.UnBlockUser(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("SetAdmin")]
        public async Task<IActionResult> SetAdmin(Guid id)
        {
            var result = await _adminService.SetAdmin(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("UnSetAdmin")]
        public async Task<IActionResult> UnSetAdmin(Guid id)
        {
            var result = await _adminService.UnSetAdmin(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _adminService.DeleteUser(id);
            return Ok(result);
        }
    }
}
