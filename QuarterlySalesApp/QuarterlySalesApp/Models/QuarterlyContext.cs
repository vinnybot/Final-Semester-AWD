using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace QuarterlySalesApp.Models
{
    public class QuarterlyContext : DbContext
    {
        public QuarterlyContext(DbContextOptions<QuarterlyContext> options) : base(options) 
        { }

        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Sale> Sales { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            { 
                EmployeeId = 1, 
                Name = "Joyce",
                LastName = "Valdez",
                DOB = new DateTime(1956, 12, 10),
                DateOfHire = new DateTime(1995, 1, 1),
                ManagerId = 0
            },
            new Employee
            { 
                EmployeeId = 2,
                Name = "Karen",
                LastName = "Freakout",
                DOB = new DateTime(1950, 1, 22),
                DateOfHire = new DateTime(2000, 2, 22),
                ManagerId = 1
            });

            modelBuilder.Entity<Sale>().HasData(
                new Sale 
                { 
                    SaleId = 1,
                    Quarter = 1,
                    Amount = 5000,
                    Year = 2020,
                    EmployeeId = 1 
                },
                new Sale 
                { 
                    SaleId = 2,
                    Quarter = 2,
                    Amount = 10000,
                    Year = 2023,
                    EmployeeId = 2 
                },
                new Sale
                {
                SaleId = 3,
                Quarter = 4,
                Amount = 12300,
                Year = 2024,
                EmployeeId = 2
                }
                );
                
        }
    }
}
