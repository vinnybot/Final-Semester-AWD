using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models.DomainModels;
using MVCHOT2.Models.DataLayer;

namespace MVCHOT2.Controllers
{
    public class ProductController : Controller
    {
        private SalesOrderContext context { get; set; }

        public ProductController(SalesOrderContext ctx) => context = ctx;

        [Route("[controller]s")]
        public IActionResult List()
        {
            var products = context.Products.Include(c => c.Category).OrderBy(x => x.ProductName).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product modifiedProduct)
        {
            if (ModelState.IsValid)
            {
                if (modifiedProduct.ProductID == 0)
                //adding a new product
                {
                    context.Products.Add(modifiedProduct);
                }
                else
                {
                    //updating an existing product
                    context.Products.Update(modifiedProduct);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedProduct.ProductID == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
                return View(modifiedProduct);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Product = context.Products.OrderBy(p => p.ProductName).ToList();
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            return View("Edit", new Product());
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

        [Route("[controller]s/{id?}")]
        public IActionResult Details(int id)
        {
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList();

            Product product = context.Products.Find(id) ?? new Product();

            string imageFilename = product.ProductImage + ".jpg";

            ViewBag.Categories = categories;
            ViewBag.ImageFilename = imageFilename;

            return View(product);
        }
    }
}
