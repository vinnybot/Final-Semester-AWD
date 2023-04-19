using Chapter_3.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chapter_3.Models.DataAccess.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> entity)
        {
            //configure the FK to not allow cascading delete
            // entity.HasOne(p => p.P).WithMany(t => t.Products);


            entity.HasData(
               new Product { ProductId = 1, Name = "Tournament Master 1.0", Code = "TRNY10", Price = 4.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 2, Name = "League Scheduler 1.0", Code = "LEAG10", Price = 4.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 3, Name = "League Scheduler Deluxe 1.0", Code = "LEAGD10", Price = 7.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 4, Name = "Draft Manager 1.0", Code = "DRAFT10", Price = 4.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 5, Name = "Team Manager 1.0", Code = "TEAM10", Price = 4.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 6, Name = "Tournament Master 2.0", Code = "TRNY20", Price = 5.99M, ReleaseDate = DateTime.Now },
               new Product { ProductId = 7, Name = "Draft Manager 2.0", Code = "DRAFT20", Price = 5.99M, ReleaseDate = DateTime.Now }

               );

        }
    }
}
