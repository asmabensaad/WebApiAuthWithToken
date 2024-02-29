using Microsoft.AspNetCore.Identity;
namespace WebApplication4.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? RfereshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
