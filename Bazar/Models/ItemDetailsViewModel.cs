using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bazar.Models
{
    public class ItemDetailsViewModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }
        public bool IsNew { get; set; }

        public bool PickupInPerson { get; set; }

        public bool CourierDelivery { get; set; }

        public string? CategoryName { get; set; }

        public string? OwnerName { get; set; }

        public string? OwnerId { get; set; }
    }
}
