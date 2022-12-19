using Bazar.Data.Models;
using Bazar.Data.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace Bazar.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public string DbPath { get; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedCategory();
            modelBuilder.SeedDeliveryMethods();
            modelBuilder.SeedPaymentMethods();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUsers();
        }
    }

}
