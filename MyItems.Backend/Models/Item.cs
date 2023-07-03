namespace MyItems.Backend.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public Item()
        {
            Id = Guid.NewGuid();
        }
    }
}