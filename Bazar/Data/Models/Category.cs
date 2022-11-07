using System.ComponentModel.DataAnnotations;

namespace Bazar.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string? Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
