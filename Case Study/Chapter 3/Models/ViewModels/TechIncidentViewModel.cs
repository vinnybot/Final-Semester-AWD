using Chapter_3.Models.DomainModels;

namespace Chapter_3.Models.ViewModels
{
    public class TechIncidentViewModel
    {
        public Technician Technician { get; set; } = null!;

        public Incident Incident { get; set; } = null!;

        public IEnumerable<Incident> Incidents { get; set; } = null!;
    }
}
