namespace MyItems.Backend.Dtos
{
    public class RegisterDto : LoginDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
