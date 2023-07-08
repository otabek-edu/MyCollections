namespace MyItems.Backend.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        
        public Guid CollectionId { get; set; }
        public required Collection Collection { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public required string Name { get; set; }
        public required string Description { get; set; }

        public List<CustomPropertyValue> CustomPropertyValues { get; set; } = new();
    }
}