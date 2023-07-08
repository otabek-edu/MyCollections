
using System.ComponentModel.DataAnnotations;

namespace MyItems.Backend.Models
{
    public class CustomProperty
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DataType TypeProperty { get; set; }

        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; } = null!;
    }
}