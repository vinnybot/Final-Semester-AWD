using Microsoft.AspNetCore.Mvc;
using MVCHOT2.Models;

namespace MVCHOT2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private SalesOrderContext context;

        public CustomerController(SalesOrderContext ctx) => context = ctx;

        [Route("[area]/[controller]s")]
        public IActionResult List()
        {
            var customers = context.Customers.OrderBy(x => x.CustomerFirstName).ToList();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer modifiedCustomer)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCustomer.CustomerID == 0)
                //adding a new product
                {
                    context.Customers.Add(modifiedCustomer);
                }
                else
                {
                    //updating an existing product
                    context.Customers.Update(modifiedCustomer);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedCustomer.CustomerID == 0) ? "Add" : "Edit";
                return View(modifiedCustomer);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Customer = context.Customers.OrderBy(p => p.CustomerFirstName).ToList();
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
    }
}
