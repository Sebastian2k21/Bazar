﻿// <auto-generated />
using System;
using Bazar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bazar.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230120181720_Init10")]
    partial class Init10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Bazar.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefony"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Narzędzia"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kosmetyki"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Zwierzęta"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Usługi"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Motoryzacja"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Ogród"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Komputery"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Monitory"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Części do komputerów"
                        });
                });

            modelBuilder.Entity("Bazar.Data.Models.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kurier"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paczkomat"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Paczka polecona"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Odbiór osobisty"
                        });
                });

            modelBuilder.Entity("Bazar.Data.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CourierDelivery")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNew")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("PickupInPerson")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<bool>("Sold")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CourierDelivery = true,
                            Description = "Telefon Samsung Galaxy S21 5G 128GB Phantom Violet",
                            IsNew = true,
                            Name = "Telefon Samsung Galaxy S21 5G",
                            PickupInPerson = false,
                            Price = 3999.0,
                            Sold = false,
                            UserId = "cc05fc2b-da9e-431d-a9dc-254c620de471"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 10,
                            CourierDelivery = false,
                            Description = "Acer Nitro VG240YBMIIX to monitor dedykowany graczom. Dzięki wysokiemu kontrastowi w ciemnych scenach czernie będą głębsze. Minusem jest niskie pokrycie kolorów. ",
                            IsNew = false,
                            Name = "Acer Nitro VG240YBMIIX czarny",
                            PickupInPerson = false,
                            Price = 599.0,
                            Sold = false,
                            UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 11,
                            CourierDelivery = false,
                            Description = "Przeznaczony do domowych i gamingowych komputerów stacjonarnych procesor AMD Ryzen 5 5600 obsłuży wymagające gry oraz zapewni obsługę zadań wielowątkowych, takich jak np. renderowanie 3D i wideo. 6 rdzeni, 12 wątków, częstotliwość taktowania do 4,4 GHz oraz 35 MB pamięci cache sprawiają, że ten CPU zapewnia najwyższą wydajność. ",
                            IsNew = true,
                            Name = "AMD Ryzen 5 5600",
                            PickupInPerson = true,
                            Price = 699.0,
                            Sold = false,
                            UserId = "3087acd6-3b79-426a-ad68-d12ef842485b"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 9,
                            CourierDelivery = false,
                            Description = "Cenisz sobie swobodę i elastyczność, jaką daje Ci zdalna praca, ale wymagasz wygody i niezawodności od swojego sprzętu? Odkryj Inspirona 15 z serii 5000 – laptopa, który dotrzyma Ci kroku.",
                            IsNew = true,
                            Name = "Dell Inspiron 5515 Ryzen 5 5500U/16GB/512/Win11",
                            PickupInPerson = true,
                            Price = 3399.0,
                            Sold = false,
                            UserId = "3087acd6-3b79-426a-ad68-d12ef842485b"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 11,
                            CourierDelivery = false,
                            Description = "Zamontuj dysk SSD WD Blue SN570 o pojemności 1 TB w swoim komputerze lub laptopie i przyspiesz znacząco jego działanie. Dysk ten jest nawet 5-krotnie szybszy w porównaniu do najbardziej wydajnych dysków SSD SATA.",
                            IsNew = true,
                            Name = "WD 1TB M.2 PCIe NVMe Blue SN570",
                            PickupInPerson = false,
                            Price = 299.0,
                            Sold = false,
                            UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced"
                        });
                });

            modelBuilder.Entity("Bazar.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuyerCity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerFullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerPhone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("BuyerStreet")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DeliveryMethodId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PaymentMethodId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("ItemId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Bazar.Data.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Przelew bankowy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BLIK"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Karta"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gotówka"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paysafecard"
                        });
                });

            modelBuilder.Entity("Bazar.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cc05fc2b-da9e-431d-a9dc-254c620de471",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7b8f4b5b-80dc-4275-8331-ca552dc9a2d7",
                            Email = "admin@bazar.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BAZAR.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDo84zAKn8N2uEqsaNdjtldrYs4sdpSvq33kGRcXXGOQNlnQqNs+l010M4nr7q/Row==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0dbe07ca-b085-49a3-9cb3-42f7319afa09",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "99d9c392-94a9-4faa-bf54-296d6c871ced",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "890fdb4c-10b6-44b5-9e8e-b64bf206cc74",
                            Email = "kamil.01@interia.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "KAMIL.01@INTERIA.PL",
                            NormalizedUserName = "KAMIL",
                            PasswordHash = "AQAAAAEAACcQAAAAEExNLNE7nskCM/jM3hVLv1zSc7F96F9sTodmD6YjIE9B4D8TKpMR68rnHJPla7/ChQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1480f580-4641-49b6-a714-3cac2f7dcf0b",
                            TwoFactorEnabled = false,
                            UserName = "Kamil"
                        },
                        new
                        {
                            Id = "3087acd6-3b79-426a-ad68-d12ef842485b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44aa2f9c-5a33-4a46-a22d-cc75f96014b0",
                            Email = "patrycja02@bazar.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PATRYCJA02@BAZAR.PL",
                            NormalizedUserName = "PATRYCJA",
                            PasswordHash = "AQAAAAEAACcQAAAAEFZaToNFpAT/hy/ScnsEDrzl9PGX5rdeeFpM9GI5SU2V64RZQ0R+v5FwDFGlf9KSig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "82016181-dbc4-4f6b-b4f4-53297bfb9c5c",
                            TwoFactorEnabled = false,
                            UserName = "Patrycja"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e91c187-f152-4ea9-a39d-e1615dbb6419",
                            ConcurrencyStamp = "3f629339-9f05-4651-9663-8df060be2db2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5",
                            ConcurrencyStamp = "2075a85c-e5b3-45e7-8a81-2270fc6b3204",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "cc05fc2b-da9e-431d-a9dc-254c620de471",
                            RoleId = "8e91c187-f152-4ea9-a39d-e1615dbb6419"
                        },
                        new
                        {
                            UserId = "99d9c392-94a9-4faa-bf54-296d6c871ced",
                            RoleId = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5"
                        },
                        new
                        {
                            UserId = "3087acd6-3b79-426a-ad68-d12ef842485b",
                            RoleId = "9244da6e-9e04-440a-b6ae-9d93cbea9aa5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bazar.Data.Models.Item", b =>
                {
                    b.HasOne("Bazar.Data.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bazar.Data.Models.User", "User")
                        .WithMany("Items")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bazar.Data.Models.Order", b =>
                {
                    b.HasOne("Bazar.Data.Models.User", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bazar.Data.Models.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bazar.Data.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bazar.Data.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("DeliveryMethod");

                    b.Navigation("Item");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bazar.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bazar.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bazar.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bazar.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bazar.Data.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Bazar.Data.Models.User", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
