using MyItems.Backend.Models;

namespace MyItems.Backend.Dtos
{
    public class CollectionDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Theme { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public List<CustomPropertyDto>? CustomProperties { get; set; }
    }
}
