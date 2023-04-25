using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCHOT2.Models.DomainModels;

namespace MVCHOT2.Models.DataLayer.Configuration
{
    public class ConfigureCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            //seed initial data
            entity.HasData(
                new Category { CategoryID = 1, Name = "Accessories" },
                new Category { CategoryID = 2, Name = "Bikes" },
                new Category { CategoryID = 3, Name = "Clothing" },
                new Category { CategoryID = 4, Name = "Car Racks" },
                new Category { CategoryID = 5, Name = "Wheels" },
                new Category { CategoryID = 6, Name = "Components" }
                );
        }
    }
}
