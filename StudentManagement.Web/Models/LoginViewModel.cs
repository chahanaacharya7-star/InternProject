using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email/Username is required.")]
        [Display(Name = "Email/Username")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Role.")]
        public string Role { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
