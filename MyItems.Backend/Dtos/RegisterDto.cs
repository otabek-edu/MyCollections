namespace MyItems.Backend.Dtos
{
    public class RegisterDto : LoginDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
