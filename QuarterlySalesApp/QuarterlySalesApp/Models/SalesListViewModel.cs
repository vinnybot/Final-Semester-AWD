namespace QuarterlySalesApp.Models
{
    public class SalesListViewModel
    {
        public List<Sale> Sales { get; set; } = null!;

        public List<Employee> Employees { get; set; } = null!;

        public int EmployeeId { get; set; }
    }
}
