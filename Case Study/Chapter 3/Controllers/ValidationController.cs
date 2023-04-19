using Microsoft.AspNetCore.Mvc;
using Chapter_3.Models.DomainModels;
using Chapter_3.Models.DataAccess;

namespace Chapter_3.Controllers
{
    public class ValidationController : Controller
    {
        private Repository<Customer> CustomerData { get; set; }

        public ValidationController(SportsProContext ctx)
        {
            CustomerData = new Repository<Customer>(ctx);
        }

        public JsonResult CheckEmail(string emailAddress, int id)
        {
            Customer customer = new Customer { Email = emailAddress, CustomerId = id };
            string msg = Check.EmailExists(CustomerData, customer);
            if (string.IsNullOrEmpty(msg))
            {
                TempData["okEmail"] = true;
                return Json(true);
            }
            else return Json(msg);
        }
    }
}
