namespace MVCHOT2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerFirstName { get; set; } = string.Empty;

        public string CustomerLastName { get; set; } = string.Empty;

        public string CustomerStreetAddress { get; set; } = string.Empty;

        public string CustomerCity { get; set; } = string.Empty;

        public string CustomerState { get; set; } = string.Empty;

        public string CustomerZipCode { get; set;} = string.Empty;

        public string CustomerPhoneNumber { get; set; } = string.Empty;
    }
}
