using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyItems.Backend.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required bool IsAdmin { get; set; }
        public required bool IsBlocked{ get; set; }
    }
}
