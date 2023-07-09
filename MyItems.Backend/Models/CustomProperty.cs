using System.Text.Json.Serialization;

namespace MyItems.Backend.Models
{
    public class CustomProperty
    {
        public Guid Id { get; set; }
        public required string TypeProperty { get; set; }

        public Guid CollectionId { get; set; }
        [JsonIgnore]
        public Collection? Collection { get; set; }

        public List<CustomPropertyValue> CustomPropertyValues { get; set; } = new();
    }
}