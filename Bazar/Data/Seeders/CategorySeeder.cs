using Bazar.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Data.Seeders
{
    public static class CategorySeeder
    {
        public static void SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category { Id = 1, Name = "Telefony"},
                new Category { Id = 2, Name = "Narzędzia"},
                new Category { Id = 3, Name = "Kosmetyki"},
                new Category { Id = 4, Name = "Zwierzęta"},
                new Category { Id = 5, Name = "Usługi"},
                new Category { Id = 6, Name = "Motoryzacja"},
                new Category { Id = 7, Name = "Ogród"},
                new Category { Id = 8, Name = "Sport"},
            });
        }
    }
}
