using MyItems.Backend.Models;

namespace MyItems.Backend.ViewModel
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public List<Collection>? Collections { get; set; }
    }
}
