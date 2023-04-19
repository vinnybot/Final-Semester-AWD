using Chapter_3.Models.DataAccess.Configuration;
using Chapter_3.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
namespace Chapter_3.Models.DataAccess
{
    public class SportsProContext : DbContext
    {
        public SportsProContext(DbContextOptions<SportsProContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Technician> Technicians { get; set; } = null!;

        public DbSet<Customer> Customer { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        public DbSet<Incident> Incidents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Technician>().HasData(
                new Technician { TechnicianId = -1, Name = "unassigned", Email = "unassigned", PhoneNumber = "unassigned" },
                new Technician { TechnicianId = 1, Name = "Alison Diaz", Email = "alison@sportsprosoftware.com", PhoneNumber = "800-555-0443" },
                new Technician { TechnicianId = 2, Name = "Andrew Wilson", Email = "awilson@sportsprosoftware.com", PhoneNumber = "800-555-0449" },
                new Technician { TechnicianId = 3, Name = "Gina Fiori", Email = "gfiori@sportsprosoftware.com", PhoneNumber = "800-555-0459" },
                new Technician { TechnicianId = 4, Name = "Gunter Wendt", Email = "gunter@sportsprosoftware.com", PhoneNumber = "800-555-0400" },
                new Technician { TechnicianId = 5, Name = "Jason Lee", Email = "jason@sportsprosoftware.com", PhoneNumber = "800-555-0444" }
                 );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "1", Name = "Zimbabwe" },
                new Country { CountryId = "2", Name = "Bolivia" },
                new Country { CountryId = "3", Name = "Mongolia" },
                new Country { CountryId = "4", Name = "Panemaw" }
                );

         

            modelBuilder.Entity<Incident>().HasData(
                new Incident { IncidentId = 1, Title = "Could not install", CustomerId = 1, ProductId = 1, TechnicianId = 1, Description = "This software is literal cheeks bro.", DateOpened = DateTime.Now }
                );

            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
