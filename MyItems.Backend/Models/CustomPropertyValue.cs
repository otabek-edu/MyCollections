using System.Text.Json.Serialization;

namespace MyItems.Backend.Models
{
    public class CustomPropertyValue
    {
        public Guid Id { get; set; }
        public required string Value { get; set; }
        
        public Guid CustomPropertyId { get; set; }
        [JsonIgnore]
        public CustomProperty? CustomProperty { get; set; }
        
        public Guid ItemId { get; set; }
        [JsonIgnore]
        public Item? Item { get; set; }
    }
}