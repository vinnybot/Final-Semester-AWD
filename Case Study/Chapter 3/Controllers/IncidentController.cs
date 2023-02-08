using Microsoft.AspNetCore.Mvc;
using Chapter_3.Models;
using Microsoft.EntityFrameworkCore;
namespace Chapter_3.Controllers
{
    public class IncidentController : Controller
    {
        private SportsProContext context { get; set; }

        public IncidentController(SportsProContext ctx) => context = ctx;
        public IActionResult List()
        {
            var incidents = context.Incidents.Include(p => p.Product).Include(c => c.Customer).ToList();
            return View(incidents);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Customer = context.Customer.OrderBy(c => c.Name).ToList();
            ViewBag.Products = context.Products.OrderBy(c => c.Name).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            return View("Edit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Customer = context.Customer.OrderBy(c => c.Name).ToList();
            ViewBag.Products = context.Products.OrderBy(c => c.Name).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident modifiedIncident)
        {
            if (ModelState.IsValid)
            {
                if (modifiedIncident.IncidentId == 0)
                //adding a new product
                {
                    context.Incidents.Add(modifiedIncident);
                }
                else
                {
                    //updating an existing product
                    context.Incidents.Update(modifiedIncident);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Incident");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedIncident.IncidentId == 0) ? "Add" : "Edit";
                ViewBag.Customer = context.Customer.OrderBy(c => c.Name).ToList();
                ViewBag.Products = context.Products.OrderBy(c => c.Name).ToList();
                ViewBag.Technicians = context.Technicians.OrderBy(t => t.Name).ToList();
                return View(modifiedIncident);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("List", "Incident");
        }
    }
}
