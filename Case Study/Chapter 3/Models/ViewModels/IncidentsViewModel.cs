using Chapter_3.Models.DomainModels;

namespace Chapter_3.Models.ViewModels
{
    public class IncidentsViewModel
    {
        public List<Incident> Incidents { get; set; } = new List<Incident>();

        public List<Incident> UnassignedIncidents { get; set; } = new List<Incident>();

        public List<Incident> OpenIncidents { get; set; } = new List<Incident>();
        public string ActiveIncident { get; set; } = "all";

        public string CheckActiveIncident(string a) => a.ToLower() == ActiveIncident.ToLower() ? "active" : "";
    }
}
