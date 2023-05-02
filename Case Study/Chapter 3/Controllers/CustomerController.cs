using Chapter_3.Models.DataAccess;
using Chapter_3.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CustomerController : Controller
    {
        private Repository<Customer> CustomerData { get; set; }
        private Repository<Country> CountryData { get; set; }

        public CustomerController(SportsProContext ctx)
        {
            CustomerData = new Repository<Customer>(ctx);
            CountryData = new Repository<Country>(ctx);
        }

        [Route("/customers")]
        public IActionResult List()
        {
            var options = new QueryOptions<Customer>()
            {
                OrderBy = c => c.Name
            };

            var customers = CustomerData.List(options);
            return View(customers);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = CountryData.List(new QueryOptions<Country>
            {
                OrderBy = c => c.Name
            });
            var customer = CustomerData.Get(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer modifiedCustomer)
        {
            //server side check for remote validation
            if (modifiedCustomer.CustomerId == 0)
            {
                string msg = Check.EmailExists(CustomerData, modifiedCustomer);
                if (!string.IsNullOrEmpty(msg))
                {
                    ModelState.AddModelError(nameof(Customer.Email), msg);
                }
            }

            if (ModelState.IsValid)
            {
                if (modifiedCustomer.CustomerId == 0)
                {
                    //add a new customer
                    CustomerData.Insert(modifiedCustomer);
                }
                else
                {
                    //update an existing customer
                    CustomerData.Update(modifiedCustomer);
                }

                CustomerData.Save();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                ViewBag.Action = (modifiedCustomer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = CountryData.List(new QueryOptions<Country>
                {
                    OrderBy = c => c.Name
                }); 
                return View(modifiedCustomer);
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = CountryData.List(new QueryOptions<Country>
            {
                OrderBy = c => c.Name
            });

            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = CustomerData.Get(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            CustomerData.Delete(customer);
            CustomerData.Save();
            return RedirectToAction("List", "Customer");
        }
    }
}
