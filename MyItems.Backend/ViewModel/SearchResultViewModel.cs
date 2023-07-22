namespace MyItems.Backend.ViewModel
{
    public class SearchResultViewModel
    {
        public List<CollectionViewModel>? Collections { get; set; } = new();
        public List<ItemViewModel>? Items { get; set; } = new();
    }
}
