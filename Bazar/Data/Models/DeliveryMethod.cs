using System.ComponentModel.DataAnnotations;

namespace Bazar.Data.Models
{
    public class DeliveryMethod
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
