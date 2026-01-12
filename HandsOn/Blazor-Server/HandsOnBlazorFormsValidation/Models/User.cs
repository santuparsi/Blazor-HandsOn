namespace HandsOnBlazorFormsValidation.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
    }

}
