using Chapter_3.Models.DataAccess;
using Chapter_3.Models.DomainModels;
using Chapter_3.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Chapter_3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RegistrationController : Controller
    {
        private Repository<Customer> CustomerData { get; set; }
        private Repository<Product> ProductData { get; set; }

        public RegistrationController(SportsProContext ctx)
        {
            CustomerData = new Repository<Customer>(ctx);
            ProductData = new Repository<Product>(ctx);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var customers = CustomerData.List(new QueryOptions<Customer>
            {
                OrderBy = c => c.Name
            });

            var vm = new RegistrationViewModel
            {
                Customers = customers,
            };
            return View(vm);
        }


        [HttpPost]
        public IActionResult Register(RegistrationViewModel vm)
        {
            if (vm.Customer.CustomerId == 0)
            {
                TempData["message"] = "You must select a customer.";
                return RedirectToAction("Index");
            } 
            else
            {
                return RedirectToAction("Register", new { id = vm.Customer.CustomerId });
            }
        }

        [HttpGet]
        public IActionResult Register(int id)
        {
            var vm = new RegistrationViewModel();

            vm.Customer = CustomerData.Get(new QueryOptions<Customer>()
            {
                Includes = "Products",
                Where = c => c.CustomerId == id
            });

            vm.Products = ProductData.List(new QueryOptions<Product>()
            {
                OrderBy = p => p.Name
            });

            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(int custId, int ProductId)
        {
            var vm = new RegistrationViewModel();
            var customer = CustomerData.Get(new QueryOptions<Customer>
            {
                Includes = "Products",
                Where = c => c.CustomerId == custId
            });
            var product = ProductData.Get(ProductId);

            if (ProductId == 0)
            {
                TempData["message"] = "Please select a product.";
                return RedirectToAction("Register", new { id = custId });
            }
            else
            {
                if (customer.Products.Any(p => p.ProductId == ProductId))
                {
                    TempData["message"] = "This product is already registered to the customer.";
                    return RedirectToAction("Register", new { id = custId });
                }
                else
                {
                    customer.Products.Add(product);
                    CustomerData.Update(customer);
                    CustomerData.Save();
                    vm.Customer = customer;
                    vm.Customer.Name = customer.Name;
                    vm.Products = ProductData.List(new QueryOptions<Product>
                    {
                        OrderBy = p => p.Name
                    });
                }
            }

            return View("Register", vm);
        }

        [HttpPost]
        public IActionResult Delete(int customerId, int productId)
        {
            var customer = CustomerData.Get(new QueryOptions<Customer>
            {
                Includes = "Products",
                Where = c => c.CustomerId == customerId
            });
            var product = customer.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                customer.Products.Remove(product);
                CustomerData.Update(customer);
                CustomerData.Save();
            }
           return RedirectToAction("Register", new { id = customerId });
        }
    }
}
