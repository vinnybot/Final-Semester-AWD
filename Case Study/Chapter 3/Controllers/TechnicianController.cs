using Chapter_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chapter_3.Controllers
{
    public class TechnicianController : Controller
    {
        private SportsProContext context { get; set; }

        public TechnicianController(SportsProContext ctx) => context = ctx;
        [Route("/technicians")]
        public IActionResult List()
        {
            var technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            return View(technicians);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
        }

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            var technicians = context.Technicians.Find(id);
            return View(technicians);
        }

        [HttpPost]
        public IActionResult Edit(Technician modifiedTechnician) {
            if (ModelState.IsValid)
            {
                if (modifiedTechnician.TechnicianId == 0)
                {
                    context.Technicians.Add(modifiedTechnician);
                }
                else
                {
                    context.Technicians.Update(modifiedTechnician);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Technician");
            }
            else
            {
                ViewBag.Action = (modifiedTechnician.TechnicianId == 0) ? "Add" : "Edit";
                return View(modifiedTechnician);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var technician = context.Technicians.Find(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            context.Technicians.Remove(technician);
            context.SaveChanges();
            return RedirectToAction("List", "Technician");
        }
    }
}
