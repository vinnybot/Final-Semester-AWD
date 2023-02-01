using Microsoft.EntityFrameworkCore;
namespace Chapter_3.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        {}

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Tournament Master 1.0", Code = "TRNY10", Price = 4.99M, ReleaseDate = "12/01/2018"},
                new Product { ProductId = 2, Name = "League Scheduler 1.0", Code = "LEAG10", Price = 4.99M, ReleaseDate = "05/01/2019" },
                new Product { ProductId = 3, Name = "League Scheduler Deluxe 1.0", Code = "LEAGD10", Price = 7.99M, ReleaseDate = "08/01/2019" },
                new Product { ProductId = 4, Name = "Draft Manager 1.0", Code = "DRAFT10", Price = 4.99M, ReleaseDate = "02/01/2020" },
                new Product { ProductId = 5, Name = "Team Manager 1.0", Code = "TEAM10", Price = 4.99M, ReleaseDate = "05/01/2020" },
                new Product { ProductId = 6, Name = "Tournament Master 2.0", Code = "TRNY20", Price = 5.99M, ReleaseDate = "02/15/2021" },
                new Product { ProductId = 7, Name = "Draft Manager 2.0", Code = "DRAFT20", Price = 5.99M, ReleaseDate = "07/15/2022" }

                );
        }
    }
}
