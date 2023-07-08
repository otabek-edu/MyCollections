namespace MyItems.Backend.Models
{
    public class Comment
    {
        public required Guid Id { get; set; }
        public required string Text { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }

        public required int UserId { get; set; }
        public User User { get; set; } = null!;

        public required Guid ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
