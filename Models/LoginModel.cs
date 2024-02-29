using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace WebApplication4.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage ="user email is required")]
        [JsonProperty("email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [JsonProperty("Password")]
        public string Password { get; set; }

    }
}
