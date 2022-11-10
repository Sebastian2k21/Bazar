using System.ComponentModel.DataAnnotations;

namespace Bazar.Models
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(50)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(30)]
        [Compare("Password")]
        [Display(Name = "Password confirmation")]
        [DataType(DataType.Password)]
        public string? PasswordConfirmation { get; set; }
    }
}
