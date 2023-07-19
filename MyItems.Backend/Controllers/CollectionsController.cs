using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyItems.Backend.Dtos;
using MyItems.Backend.Results;
using MyItems.Backend.Services;
using System.Security.Claims;

namespace MyItems.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionsController : ControllerBase
    {
        private readonly CollectionService _collectionService;

        public CollectionsController(CollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCollections()
        {
            var collection = await _collectionService.GetCollections();
            return Ok(collection);
        }

        [HttpGet("user/{userID}")]
        public async Task<IActionResult> GetCollections(Guid userID)
        {
            var collection = await _collectionService.GetCollectionById(userID);
            return Ok(collection);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCollectionById(Guid id)
        {
            var collection = await _collectionService.GetCollectionById(id);
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
