using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
