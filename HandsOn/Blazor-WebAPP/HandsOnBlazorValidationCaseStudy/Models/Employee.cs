using HandsOnBlazorValidationCaseStudy.Validators;
using System.ComponentModel.DataAnnotations;
using System.Net;
namespace HandsOnBlazorValidationCaseStudy.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [CompanyEmail]
        public string Email { get; set; }

        [Range(21, 60, ErrorMessage = "Age must be between 21 and 60")]
        public int Age { get; set; }

      
    }

}
