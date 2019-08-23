using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords are not matching")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
