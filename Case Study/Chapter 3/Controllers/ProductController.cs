using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Chapter_3.Models.DomainModels;
using Chapter_3.Models.DataAccess;

namespace Chapter_3.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> ProductData { get; set; }

        public ProductController(SportsProContext ctx)
        {
            ProductData = new Repository<Product>(ctx);
        }

        [Route("/products")]
        public IActionResult List()
        {
            var options = new QueryOptions<Product>()
            {
                OrderBy = p => p.Price
            };

            var products = ProductData.List(options);
            //var products = context.Products.OrderBy(p => p.ReleaseDate).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = ProductData.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product modifiedProduct)
        {
            if (ModelState.IsValid)
            {
                if (modifiedProduct.ProductId == 0)
                //adding a new product
                {
                    ProductData.Insert(modifiedProduct);    
                }
                else
                {
                    //updating an existing product
                    ProductData.Update(modifiedProduct);
                }

                TempData["message"] = $"{modifiedProduct.Name} product was added.";
                ProductData.Save();
                return RedirectToAction("List", "Product");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedProduct.ProductId == 0) ? "Add" : "Edit";
                return View(modifiedProduct);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = ProductData.Get(id);
                return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            TempData["message"] = $"{product.Name} Deleted!";
            ProductData.Delete(product);
            ProductData.Save();
            return RedirectToAction("List", "Product");
        }
    }
}


            // Monday - Encapsulate the data layer for the remaining controllers. (Technicians and Registrations)
            //If there is time, finish fixing the bug with customers where they are able to edit there email to an already existing email by bypassing the
            //email check
