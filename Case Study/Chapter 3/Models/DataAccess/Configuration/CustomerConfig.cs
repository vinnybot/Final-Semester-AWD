using Chapter_3.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chapter_3.Models.DataAccess.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            //configure the FK to not allow cascading delete
            // entity.HasMany(t => t.Products).WithMany(t => t.Customers);

           entity.HasData(
             new Customer { CustomerId = 1, Name = "Vincent Bottini", Email = "VincentBottini@insideranken.org", City = "Saint Louis", PostalCode = "63110", CountryId = "1", PhoneNumber = "314-349-8201", State = "Missouri", Address = "444 Sun Lane" }
             );
        }
    }
}
