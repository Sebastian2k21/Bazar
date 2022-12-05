using Bazar.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bazar.Data.Seeders
{
    public static class Seeder
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

        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(new[]
            {
                new IdentityRole { Id = "8e91c187-f152-4ea9-a39d-e1615dbb6419", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp="3f629339-9f05-4651-9663-8df060be2db2" },
                new IdentityRole { Id = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5", Name = "User", NormalizedName = "USER", 
                    ConcurrencyStamp="2075a85c-e5b3-45e7-8a81-2270fc6b3204" }
            });
        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User
                {
                    Id = "cc05fc2b-da9e-431d-a9dc-254c620de471",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@bazar.pl",
                    NormalizedEmail = "ADMIN@BAZAR.PL",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin123"),
                    ConcurrencyStamp = "7b8f4b5b-80dc-4275-8331-ca552dc9a2d7",
                    SecurityStamp = "9cd5719e-04a6-41c4-91af-a762759806cc"
                }
            });
        }
    }
}
