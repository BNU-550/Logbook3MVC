using System.ComponentModel.DataAnnotations;

namespace Logbook3MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, ]
        public string Name { get; set; } =  String.Empty;

        public string Email { get; set; } = String.Empty;

        public string? PhoneNumber { get; set; } = null;
    }
}
