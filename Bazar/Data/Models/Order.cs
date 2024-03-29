﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bazar.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Item? Item { get; set; }

        [ForeignKey("Item")]
        public int? ItemId { get; set; }

        [Required]
        public User? Buyer { get; set; }

        [ForeignKey("User")]
        public string? BuyerId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        public string? BuyerStreet { get; set; }

        [Required]
        [MaxLength(100)]
        public string? BuyerCity { get; set; }

        [Required]
        [MaxLength(100)]
        public string? BuyerEmail { get; set; }

        [Required]
        [MaxLength(15)]
        public string? BuyerPhone { get; set; }

        [Required]
        [MaxLength(100)]
        public string? BuyerFullName { get; set; }

        [MaxLength(200)]
        public string? Comment { get; set; }

        [Required]
        public PaymentMethod? PaymentMethod { get; set; }

        [ForeignKey("PaymentMethod")]
        public int? PaymentMethodId { get; set; }

        [Required]
        
        public DeliveryMethod? DeliveryMethod { get; set; }

        [ForeignKey("DeliveryMethod")]
        public int? DeliveryMethodId { get; set; }
    }
}
