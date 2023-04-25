using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models.DomainModels;
using MVCHOT2.Models.DataLayer;

namespace MVCHOT2.Controllers
{
    public class CategoryController : Controller
    {
        private SalesOrderContext context { get; set; }

        public CategoryController(SalesOrderContext ctx) => context = ctx;

        [Route("[controller]")]
        public IActionResult List()
        {
            var categories = context.Categories.OrderBy(x => x.CategoryID).ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var categories = context.Categories.Find(id);
            return View(categories);
        }

        [HttpPost]
        public IActionResult Edit(Category modifiedCategory)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCategory.CategoryID == 0)
                //adding a new customer
                {
                    context.Categories.Add(modifiedCategory);
                }
                else
                {
                    //updating an existing category
                    context.Categories.Update(modifiedCategory);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Category");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedCategory.CategoryID == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
                return View(modifiedCategory);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.ToList();
            return View("Edit", new Category());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categories = context.Categories.Find(id);
            return View(categories);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("List", "Category");
        }
    }
}
