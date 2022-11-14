using Bazar.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class ItemViewModel
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }


        [Required]
        public double Price { get; set; }

        [Display(Name = "New")]
        public bool IsNew { get; set; }

        [Display(Name = "Pickup in person")]
        public bool PickupInPerson { get; set; }

        [Display(Name = "Courier delivery")]
        public bool CourierDelivery { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

    }

}

