using Microsoft.EntityFrameworkCore;
namespace Chapter_3.Models
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
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Tournament Master 1.0", Code = "TRNY10", Price = 4.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 2, Name = "League Scheduler 1.0", Code = "LEAG10", Price = 4.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 3, Name = "League Scheduler Deluxe 1.0", Code = "LEAGD10", Price = 7.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 4, Name = "Draft Manager 1.0", Code = "DRAFT10", Price = 4.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 5, Name = "Team Manager 1.0", Code = "TEAM10", Price = 4.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 6, Name = "Tournament Master 2.0", Code = "TRNY20", Price = 5.99M, ReleaseDate = DateTime.Now },
                new Product { ProductId = 7, Name = "Draft Manager 2.0", Code = "DRAFT20", Price = 5.99M, ReleaseDate = DateTime.Now }

                );

            modelBuilder.Entity<Technician>().HasData(
                new Technician { TechnicianId = 1, Name = "Alison Diaz", Email = "alison@sportsprosoftware.com", PhoneNumber = "800-555-0443" },
                new Technician { TechnicianId = 2, Name = "Andrew Wilson", Email = "awilson@sportsprosoftware.com", PhoneNumber = "800-555-0449" },
                new Technician { TechnicianId = 3, Name = "Gina Fiori", Email = "gfiori@sportsprosoftware.com", PhoneNumber = "800-555-0459" },
                new Technician { TechnicianId = 4, Name = "Gunter Wendt", Email = "gunter@sportsprosoftware.com", PhoneNumber = "800-555-0400" },
                new Technician { TechnicianId = 5, Name = "Jason Lee", Email = "jason@sportsprosoftware.com", PhoneNumber = "800-555-0444" }
                 );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "Z", Name = "Zimbabwe" },
                new Country { CountryId = "B", Name = "Bolivia" },
                new Country { CountryId = "M", Name = "Mongolia" },
                new Country { CountryId = "P", Name = "Panemaw" }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "Vincent Bottini", Email = "VincentBottini@insideranken.org", City = "Saint Louis", PostalCode = 63110, CountryId = "Z", PhoneNumber = "314-349-8201", State = "Missouri", Address = "444 Sun Lane" }
                );

            modelBuilder.Entity<Incident>().HasData(
                new Incident { IncidentId = 1, Title = "Could not install", CustomerId = 1, ProductId = 1, TechnicianId = 1, Description = "This software is literal cheeks bro.", DateOpened = DateTime.Now }
                );
        }
    }
}
