using System.Text.Json.Serialization;

namespace MyItems.Backend.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid CollectionId { get; set; }
        [JsonIgnore]
        public Collection? Collection { get; set; } = null!;
        
        public List<CustomPropertyValue> CustomPropertyValues { get; set; } = new();
    }
}