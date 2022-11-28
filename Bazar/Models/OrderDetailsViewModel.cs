using Bazar.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class OrderDetailsViewModel
    {

        public DateTime Date { get; set; } = DateTime.Now;

        public string? BuyerStreet { get; set; }
        
        public string? BuyerCity { get; set; }

        public string? BuyerEmail { get; set; }

        public string? BuyerPhone { get; set; }

        public string? BuyerFullName { get; set; }

        public string? Comment { get; set; }

        public string? PaymentMethodName { get; set; }

        public string? DeliveryMethodName { get; set; }
        
        public int ItemId { get; set; }
        
        public string? ItemName { get; set; }
    }
}
