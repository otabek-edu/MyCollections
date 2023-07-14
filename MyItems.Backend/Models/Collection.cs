using System.Text.Json.Serialization;

namespace MyItems.Backend.Models
{
    public class Collection
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Theme { get; set; }
        public required string ImageUrl { get; set; }

        public Guid UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

        public List<Item> Items { get; set; } = new();
        public List<CustomProperty> CustomProperties { get; set; } = new();
    }
}
