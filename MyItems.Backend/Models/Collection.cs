namespace MyItems.Backend.Models
{
    public class Collection
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Theme { get; set; }
        public required string ImageUrl { get; set; }

        public required int UserId { get; set; }
        public User User { get; set; } = null!;
        public List<Item>? Items { get; set; }
    }
}
