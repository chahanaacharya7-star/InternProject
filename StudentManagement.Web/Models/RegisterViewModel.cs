using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email/Username is required.")]
        [Display(Name = "Email/Username")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Role.")]
        public string Role { get; set; } = string.Empty;
    }
}
