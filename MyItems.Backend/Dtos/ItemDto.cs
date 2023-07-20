namespace MyItems.Backend.Dtos
{
    public class ItemDto
    {
        public string Name { get; set; } = null!;
        public Guid CollectionId { get; set; }

        public List<CustomPropertyValueDto>? CustomPropertyValues { get; set; }
    }
}