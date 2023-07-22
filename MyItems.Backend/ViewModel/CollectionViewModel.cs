using MyItems.Backend.Models;

namespace MyItems.Backend.ViewModel
{
    public class CollectionViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ItemsCount { get; set; }
        public string? Theme { get; set; }
        public string? ImageUrl { get; set; }
        public Guid? UserId { get; set; }
        public string? Author { get; set; }
        public List<Item>? Items { get; set; } = new();
        public List<CustomProperty>? CustomProperties { get; set; } = new();
    }
}
