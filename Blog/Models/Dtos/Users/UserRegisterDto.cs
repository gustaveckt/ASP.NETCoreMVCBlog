using Blog.Static;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Dtos.Users
{
    public class UserRegisterDto
    {
        public UserRegisterDto() => Role = AppRoles.User;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public string? FirstName { get; set; }

        [Required]
        public string LastName { get; set; } = null!;

        public string? Role { get; set; }
        public string PublicName { get; set; } = null!;
    }
}