using System.ComponentModel.DataAnnotations;

namespace Logbook3MVC.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string HouseNumber { get; set; } = string.Empty;

        [Required, StringLength(10)]

        public string PostCode { get; set; } = string.Empty ;
    }
}
