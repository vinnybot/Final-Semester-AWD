using Chapter_3.Models.DomainModels;

namespace Chapter_3.Models.ViewModels
{
    public class RegistrationViewModel
    {

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
