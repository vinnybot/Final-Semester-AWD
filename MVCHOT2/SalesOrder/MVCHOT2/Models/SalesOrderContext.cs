using Microsoft.EntityFrameworkCore;

namespace MVCHOT2.Models
{
    public class SalesOrderContext : DbContext
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options) : base(options) 
        { }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "AeroFlo ATB Wheels", ShortDescription = "", LongDescription = "", Image = "", Price = 189.00M, Quantity = 40, CategoryId = "C"  },
                new Product { ProductId = 2, Name = "Clear Shade 85-T Glasses", ShortDescription = "", LongDescription = "", Image = "", Price = 45.00M, Quantity = 14, CategoryId = "A" },
                new Product { ProductId = 3, Name = "Cosmic Elite Road Warrior Wheels", ShortDescription = "", LongDescription = "", Image = "", Price = 165.00M, Quantity = 22, CategoryId = "C" },
                new Product { ProductId = 4, Name = "Cycle-Doc Pro Repair Stand", ShortDescription = "", LongDescription = "", Image = "", Price = 166.00M, Quantity = 12, CategoryId = "A" },
                new Product { ProductId = 5, Name = "Dog Ear Aero-Flow Floor Pump", ShortDescription = "", LongDescription = "", Image = "", Price = 55.00M, Quantity = 25, CategoryId = "A" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "A", Name = "Accessories"},
                new Category { CategoryId = "C", Name = "Components"}
                );
        }
    }
}
