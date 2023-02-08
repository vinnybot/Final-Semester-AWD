using Chapter_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_3.Controllers
{
    public class CustomerController : Controller
    {
        private SportsProContext context { get; set; }
        
        public CustomerController(SportsProContext ctx) => context = ctx;


        public IActionResult List()
        {
            var customers = context.Customer.OrderBy(t => t.Name).ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
            var customer = context.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer modifiedCustomer)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCustomer.CustomerId == 0)
                {
                    context.Customer.Add(modifiedCustomer);
                }
                else
                {
                    context.Customer.Update(modifiedCustomer);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                ViewBag.Action = (modifiedCustomer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
                return View(modifiedCustomer);
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customer.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
    }
}
