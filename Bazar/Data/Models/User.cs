using System.ComponentModel.DataAnnotations;

namespace Bazar.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Password { get; set; }

        public List<Item> Items { get; set; }
        public List<Order> Orders { get; set; }
    }
}
