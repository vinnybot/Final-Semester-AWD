using Microsoft.EntityFrameworkCore;
namespace Chapter_8.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
        : base(options) { }

        public DbSet<Trip> Trips { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trip>().HasData(
                new Trip { 
                    TripID = 1, 
                    Destination = "Kenya", 
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Now, 
                    Accommodation = "Holiday Inn Express", 
                    Activity1 = "Eat", 
                    Activity2 = "Sleep", 
                    Activity3 = "Fart"
                }
                );
        }
    }
}
