using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailExists", controller: "Account")]
        [ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage = "Email domain must be gmail.com")]
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
