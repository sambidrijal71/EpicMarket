using Microsoft.AspNetCore.Identity;

namespace server.Entity
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}