using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;
using MyItems.Backend.ViewModel;

namespace MyItems.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(Guid id)
        {
            var item = await _context.Items
                .Include(i => i.Collection)
                .Include(i => i.CustomPropertyValues)
                    .ThenInclude(i => i.CustomProperty)
                    .Select(i => new ItemViewModel
                    {
                        Id = i.Id,
                        Name = i.Name,
                        CollectionId = i.Collection.Id,
                        CollectionName = i.Collection.Name,
                        AuthorId = i.Collection.User.Id,
                        Author = i.Collection.User.FirstName + " " + i.Collection.User.LastName,
                        CreatedAt = i.CreatedAt.ToShortDateString(),
                        CustomPropertyValues = i.CustomPropertyValues.Select(cpv => new CustomPropertyValueViewModel
                        {
                            Id = cpv.Id,
                            Value = cpv.Value,
                            CustomPropertyId = cpv.CustomProperty.Id,
                            CustomPropertyName = cpv.CustomProperty.Name,
                            CustomPropertyType = cpv.CustomProperty.TypeProperty
                        }).ToList()
                    })
                .FirstOrDefaultAsync(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();

            return Ok(item);
        }

        [HttpPost("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateItem(Guid id, Item item)
        {
            var existingItem = await _context.Items.FirstOrDefaultAsync(i => i.Id == id);

            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.Name = item.Name;
            existingItem.CollectionId = item.CollectionId;

            await _context.SaveChangesAsync();

            return Ok(existingItem);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            var existingItem = await _context.Items.FirstOrDefaultAsync(i => i.Id == id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _context.Items.Remove(existingItem);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
