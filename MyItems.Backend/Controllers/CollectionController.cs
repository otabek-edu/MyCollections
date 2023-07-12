using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyItems.Backend.Dtos;
using MyItems.Backend.Results;
using MyItems.Backend.Services;
using System.Security.Claims;

namespace MyItems.Backend.Controllers
{
    public class CollectionController : ControllerBase
    {
        private readonly CollectionService _collectionService;

        public CollectionController(CollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCollection(Guid id)
        {
            var collection = await _collectionService.GetCollection(id);
            return Ok(collection);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCollection([FromBody] CollectionDto collection, Guid userId)
        {
            var userIdInSystem = Guid.Empty;
            Guid.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userIdInSystem);
            
            if (userIdInSystem != userId && User.FindFirstValue(ClaimTypes.Role) != "Admin")
                return Ok(new ErrorResult(""));

            var result = await _collectionService.CreateCollection(collection, userId);
            return Ok(result);
        }


    }
}
