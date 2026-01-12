using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorFormsValidation.Models
{
    public class RegisterUser
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }

}
