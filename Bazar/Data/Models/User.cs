using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Bazar.Data.Models
{
    public class User : IdentityUser
    {
        public List<Item> Items { get; set; }
        public List<Order> Orders { get; set; }
    }
}
