namespace MyItems.Backend.ViewModel
{
    public class ItemViewModel
    {
        public Guid Id { get; set; }
        public Guid CollectionId { get; set; }
        public Guid AuthorId { get; set; }
        public string? Name { get; set; }
        public string? CollectionName { get; set; }
        public string? Author { get; set; }
    }
}
