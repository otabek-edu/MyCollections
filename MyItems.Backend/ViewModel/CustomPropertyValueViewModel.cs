namespace MyItems.Backend.ViewModel
{
    public class CustomPropertyValueViewModel
    {
        public Guid Id { get; set; }
        public string? Value { get; set; }
        public Guid CustomPropertyId { get; set; }
        public string? CustomPropertyName { get; set; }
        public string? CustomPropertyType { get; set; }
    }
}
