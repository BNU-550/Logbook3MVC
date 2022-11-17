using System.ComponentModel.DataAnnotations;

namespace Logbook3MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public int AddressId { get; set; }
        
        [Required, StringLength(20)]
        public string Name { get; set; } =  String.Empty;

        [Required, StringLength(20), DataType(DataType.EmailAddress)]

        public string Email { get; set; } = String.Empty;
        [StringLength(20), DataType(DataType.PhoneNumber)]

        public string? PhoneNumber { get; set; } = null;

        // Navigation properties

        public Address? Address { get; set; }
    }
}
