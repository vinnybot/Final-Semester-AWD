using Microsoft.AspNetCore.Mvc;
using Chapter_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Chapter_3.Controllers
{
    public class ProductController : Controller
    {
        private SportsProContext context { get; set; }

        public ProductController(SportsProContext ctx) => context = ctx;

        [Route("/products")]
        public IActionResult List()
        {
            var products = context.Products.OrderBy(p => p.ReleaseDate).ToList();
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
            var product = context.Products.Find(id);
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
                    context.Products.Add(modifiedProduct);
                }
                else
                {
                    //updating an existing product
                    context.Products.Update(modifiedProduct);
                }

                TempData["message"] = $"{modifiedProduct.Name} product was added.";
                context.SaveChanges();
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
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
