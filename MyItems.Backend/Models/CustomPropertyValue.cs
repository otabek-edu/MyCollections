namespace MyItems.Backend.Models
{
    public class CustomPropertyValue
    {
        public Guid Id { get; set; }
        
        public Guid CustomPropertyId { get; set; }
        public CustomProperty CustomProperty { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public string Value { get; set; }
    }
}