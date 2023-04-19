using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TripLog2.Models.DomainModels;

namespace TripLog2.Models.DataAccess.Configuration
{
    public class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> entity)
        {
            //configure the FK to not allow cascading delete
            entity.HasOne(t => t.Destination)
                .WithMany(d => d.Trips)
                .OnDelete(DeleteBehavior.Restrict);

            //configure the accomodation FK to now allow cascading delete
            entity.HasOne(t => t.Accomodation)
                .WithMany(a => a.Trips)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
