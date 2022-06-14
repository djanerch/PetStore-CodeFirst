using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PetStore.Common;
using PetStore.Infrastructure.Models;

namespace PetStore.Infrastructure
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext()
        {
        }
        public PetStoreContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
