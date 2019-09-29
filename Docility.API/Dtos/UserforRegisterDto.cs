using System.ComponentModel.DataAnnotations;

namespace Docility.API.Dtos
{
    public class UserforRegisterDto
    {   
        [Required(ErrorMessage = "Username is requried")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is requried")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is requried")]
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}