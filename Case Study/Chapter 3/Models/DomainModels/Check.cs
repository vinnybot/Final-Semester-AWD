using Chapter_3.Models.DataAccess;

namespace Chapter_3.Models.DomainModels
{
    public static class Check
    {
        public static string EmailExists(Repository<Customer> CustomerData, Customer customer)
        {
            string msg = string.Empty;
            if (!string.IsNullOrEmpty(customer.Email))
            {
                var dbCustomer = CustomerData.Get(new QueryOptions<Customer>
                {
                    Where = c => c.Email == customer.Email && c.CustomerId != customer.CustomerId,
                });

                if (dbCustomer != null)
                {
                    msg = $"Email address {customer.Email} is already in use.";
                }
            }
            return msg;
        }
    }
}
