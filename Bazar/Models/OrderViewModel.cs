using Bazar.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class OrderViewModel
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "Street")]
        public string? BuyerStreet { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "City")]
        public string? BuyerCity { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Email")]
        public string? BuyerEmail { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Phone")]
        public string? BuyerPhone { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Full name")]
        public string? BuyerFullName { get; set; }

        [MaxLength(200)]
        public string? Comment { get; set; }

        [Required]
        [Display(Name = "Payment method")]
        public int? PaymentMethodId { get; set; }

        [Required]
        [Display(Name = "Delivery method")]
        public int? DeliveryMethodId { get; set; }
    }
}
