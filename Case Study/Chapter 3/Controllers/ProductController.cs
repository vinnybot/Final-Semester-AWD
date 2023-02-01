using Microsoft.AspNetCore.Mvc;
using Chapter_3.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter_3.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext context { get; set; }

        public ProductController(ProductContext ctx) => context = ctx;

        public IActionResult List()
        {
            var products = context.Products.OrderBy(p => p.ReleaseDate).ToList();
            return View(products);
        }
    }
}
