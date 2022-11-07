using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bazar.Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }


        [Required]
        public double Price { get; set; }

        public bool IsNew { get; set; }

        public bool PickupInPerson { get; set; }

        public bool CourierDelivery { get; set; }

        [Required]
        public Category? Category { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        [Required]
        public User? User { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
    }
}
