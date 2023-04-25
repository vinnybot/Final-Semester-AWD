using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MVCHOT2.Models.DataLayer.Configuration;

namespace MVCHOT2.Models.DataLayer
{
    public class SalesOrderContext : IdentityDbContext<User>
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //configure entities
            builder.ApplyConfiguration(new ConfigureProduct());
            builder.ApplyConfiguration(new ConfigureCategory());
            builder.ApplyConfiguration(new ConfigureCustomer());
        }
    }
}
