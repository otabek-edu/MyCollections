using MyItems.Backend.Models;

namespace MyItems.Backend.ViewModel
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }

        //public List<Collection>? Collections { get; set; }
    }
}
