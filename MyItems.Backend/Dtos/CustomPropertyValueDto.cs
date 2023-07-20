namespace MyItems.Backend.Dtos
{
    public class CustomPropertyValueDto
    {
        public string Value { get; set; } = null!;
        public Guid CustomPropertyId { get; set; }
    }
}