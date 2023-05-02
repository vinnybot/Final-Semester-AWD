using Chapter_3.Models.DataAccess;
using Chapter_3.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Chapter_3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TechnicianController : Controller
    {
        //private SportsProContext context { get; set; }

        private Repository<Technician> TechnicianData { get; set; }

        public TechnicianController(SportsProContext ctx)
        {
            TechnicianData = new Repository<Technician>(ctx);
        }

        [Route("/technicians")]
        public IActionResult List()
        {
            var options = new QueryOptions<Technician>()
            {
                OrderBy = t => t.Name
            };

            var technicians = TechnicianData.List(options);

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
            var technicians = TechnicianData.Get(id);
            return View(technicians);
        }

        [HttpPost]
        public IActionResult Edit(Technician modifiedTechnician) {
            if (ModelState.IsValid)
            {
                if (modifiedTechnician.TechnicianId == 0)
                {
                    //add a new technician
                    TechnicianData.Insert(modifiedTechnician);
                }
                else
                {
                    //update an existing technician
                    TechnicianData.Update(modifiedTechnician);
                }
                TechnicianData.Save();
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
            var technician = TechnicianData.Get(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            TechnicianData.Delete(technician);
            TechnicianData.Save();
            return RedirectToAction("List", "Technician");
        }
    }
}
