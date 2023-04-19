using Chapter_3.Models.DomainModels;

namespace Chapter_3.Models.ViewModels
{
    public class IncidentViewModel
    {
        public Incident Incident { get; set; } = null!;

        public IEnumerable<Customer> Customers { get; set; } = null!;
        public IEnumerable<Product> Products { get; set; } = null!;
        public IEnumerable<Technician> Technicians { get; set; } = null!;
    }
}
