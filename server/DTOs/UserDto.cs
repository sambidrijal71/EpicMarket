namespace server.DTOs
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public CartDto Cart { get; set; }
    }
}