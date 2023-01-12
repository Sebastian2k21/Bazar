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
                new Category { Id = 9, Name = "Komputery"},
                new Category { Id = 10, Name = "Monitory"},
                new Category { Id = 11, Name = "Części do komputerów"},
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

            Dictionary<string, string>[] users = new Dictionary<string, string>[]
            {
                new()
                {
                    { "Id", "cc05fc2b-da9e-431d-a9dc-254c620de471" },
                    { "UserName", "admin" },
                    { "Email", "admin@bazar.pl" },
                    { "Password", "Admin123" },
                    { "ConcurrencyStamp", "7b8f4b5b-80dc-4275-8331-ca552dc9a2d7" }
                },
                new()
                {
                    { "Id", "99d9c392-94a9-4faa-bf54-296d6c871ced" },
                    { "UserName", "Kamil" },
                    { "Email", "kamil.01@interia.pl" },
                    { "Password", "kamil01" },
                    { "ConcurrencyStamp", "890fdb4c-10b6-44b5-9e8e-b64bf206cc74" }
                },
                new()
                {
                    { "Id", "3087acd6-3b79-426a-ad68-d12ef842485b" },
                    { "UserName", "Patrycja" },
                    { "Email", "patrycja02@bazar.pl" },
                    { "Password", "patrycja02" },
                    { "ConcurrencyStamp", "44aa2f9c-5a33-4a46-a22d-cc75f96014b0" }
                },
            };

            modelBuilder.Entity<User>().HasData(
             users.Select(u => new User
             {
                 Id = u["Id"],
                 UserName = u["UserName"],
                 NormalizedUserName = u["UserName"].ToUpper(),
                 Email = u["Email"],
                 NormalizedEmail = u["Email"].ToUpper(),
                 EmailConfirmed = true,
                 PasswordHash = hasher.HashPassword(null, u["Password"]),
                 ConcurrencyStamp = u["ConcurrencyStamp"]
             }).ToArray()
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new[]
            {
                new IdentityUserRole<string> {UserId = "cc05fc2b-da9e-431d-a9dc-254c620de471", RoleId = "8e91c187-f152-4ea9-a39d-e1615dbb6419"},
                new IdentityUserRole<string> {UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced", RoleId = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5"},
                new IdentityUserRole<string> {UserId = "3087acd6-3b79-426a-ad68-d12ef842485b", RoleId = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5"}
            });
        }

        public static void SeedItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new[]
            {
                new Item
                {
                    Id = 1,
                    Name = "Telefon Samsung Galaxy S21 5G",
                    Description = "Telefon Samsung Galaxy S21 5G 128GB Phantom Violet",
                    Price = 3999,
                    CategoryId = 1,
                    CourierDelivery = true,
                    UserId = "cc05fc2b-da9e-431d-a9dc-254c620de471",
                    IsNew = true
                },
                new Item
                {
                    Id = 2,
                    Name = "Acer Nitro VG240YBMIIX czarny",
                    Description = "Acer Nitro VG240YBMIIX to monitor dedykowany graczom. Dzięki wysokiemu kontrastowi w ciemnych scenach czernie będą głębsze. Minusem jest niskie pokrycie kolorów. ",
                    Price = 599,
                    CategoryId = 10,
                    UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced"
                },
                new Item
                {
                    Id = 3,
                    Name = "AMD Ryzen 5 5600",
                    Description = "Przeznaczony do domowych i gamingowych komputerów stacjonarnych procesor AMD Ryzen 5 5600 obsłuży wymagające gry oraz zapewni obsługę zadań wielowątkowych, takich jak np. renderowanie 3D i wideo. 6 rdzeni, 12 wątków, częstotliwość taktowania do 4,4 GHz oraz 35 MB pamięci cache sprawiają, że ten CPU zapewnia najwyższą wydajność. ",
                    Price = 699,
                    CategoryId = 11,
                    UserId = "3087acd6-3b79-426a-ad68-d12ef842485b",
                    IsNew = true,
                    PickupInPerson = true,
                },
                new Item
                {
                    Id = 4,
                    Name = "Dell Inspiron 5515 Ryzen 5 5500U/16GB/512/Win11",
                    Description = "Cenisz sobie swobodę i elastyczność, jaką daje Ci zdalna praca, ale wymagasz wygody i niezawodności od swojego sprzętu? Odkryj Inspirona 15 z serii 5000 – laptopa, który dotrzyma Ci kroku.",
                    Price = 3399,
                    CategoryId = 9,
                    UserId = "3087acd6-3b79-426a-ad68-d12ef842485b",
                    IsNew = true,
                    PickupInPerson = true,
                },
                 new Item
                {
                    Id = 5,
                    Name = "WD 1TB M.2 PCIe NVMe Blue SN570",
                    Description = "Zamontuj dysk SSD WD Blue SN570 o pojemności 1 TB w swoim komputerze lub laptopie i przyspiesz znacząco jego działanie. Dysk ten jest nawet 5-krotnie szybszy w porównaniu do najbardziej wydajnych dysków SSD SATA.",
                    Price = 299,
                    CategoryId = 11,
                    UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced",
                    IsNew = true,
                }
            });
        }
    }
}
