using System.ComponentModel.DataAnnotations;

namespace BlazorWasmECommerce.Models;

public class Order
{
    [Required]
    public string CustomerName { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Address { get; set; }
}
