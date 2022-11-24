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

        public static void SeedDeliveryMethods(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeliveryMethod>().HasData(new[]
            {
                new DeliveryMethod { Id = 1, Name = "Kurier"},
                new DeliveryMethod { Id = 2, Name = "Paczkomat"},
                new DeliveryMethod { Id = 3, Name = "Paczka polecona"},
                new DeliveryMethod { Id = 4, Name = "Odbiór osobisty"}
            });
        }

        public static void SeedPaymentMethods(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentMethod>().HasData(new[]
            {
                new PaymentMethod { Id = 1, Name = "Przelew bankowy"},
                new PaymentMethod { Id = 2, Name = "BLIK"},
                new PaymentMethod { Id = 3, Name = "Karta"},
                new PaymentMethod { Id = 4, Name = "Gotówka"},
                new PaymentMethod { Id = 5, Name = "Paysafecard"}
            });
        }
    }
}
