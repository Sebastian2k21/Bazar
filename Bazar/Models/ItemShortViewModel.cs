using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class ItemShortViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
    }
}
