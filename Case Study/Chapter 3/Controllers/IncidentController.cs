using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chapter_3.Models.ViewModels;
using Chapter_3.Models.DomainModels;
using Chapter_3.Models.DataAccess;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Chapter_3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IncidentController : Controller
    {
        private Repository<Incident> IncidentData { get; set; }
        private Repository<Customer> CustomerData { get; set; }
        private Repository<Product> ProductData { get; set; }

        private Repository<Technician> TechnicianData { get; set; }

        public IncidentController(SportsProContext ctx)
        {
            IncidentData = new Repository<Incident>(ctx);
            CustomerData = new Repository<Customer>(ctx);
            ProductData = new Repository<Product>(ctx);
            TechnicianData = new Repository<Technician>(ctx);
        }

        [Route("/incidents")]
        public IActionResult List()
        {
            var options = new QueryOptions<Incident>
            {
                Includes = "Customer, Product, Technician",
                OrderBy = t => t.IncidentId!

            };

            var incident = IncidentData.List(options);

            //vm.Incidents = context.Incidents.Include(c => c.Customer).Include(p => p.Product).Include(t => t.Technician).ToList();

            return View(incident);
        }

        [Route("/incidents/unassigned")]
        public IActionResult unassignedFilter()
        {
            var options = new QueryOptions<Incident>
            {
                Includes = "Customer, Product, Technician",
                Where = t => t.TechnicianId == -1
            };

            var incident = IncidentData.List(options);


            //vm.Incidents = context.Incidents.Include(c => c.Customer).Include(p => p.Product).Include(t => t.Technician).ToList();
            //var query = vm.Incidents.Where(i => i.TechnicianId == -1);
            return View("List", incident);
        }

        [Route("/incidents/open")]
        public IActionResult openFilter()
        {
            var options = new QueryOptions<Incident>
            {
                Includes = "Customer, Product, Technician",
                Where = t => t.DateClosed == null
            };

            var incident = IncidentData.List(options);
            //vm.Incidents = context.Incidents.Include(c => c.Customer).Include(p => p.Product).Include(t => t.Technician).ToList();
            //var query = vm.Incidents.Where(i => i.DateClosed == null);
            return View("List", incident);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Customer = CustomerData.List(new QueryOptions<Customer>());
            ViewBag.Products = ProductData.List(new QueryOptions<Product>());
            ViewBag.Technicians = TechnicianData.List(new QueryOptions<Technician>());

            return View("Edit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Customer = CustomerData.List(new QueryOptions<Customer>());
            ViewBag.Products = ProductData.List(new QueryOptions<Product>());
            ViewBag.Technicians = TechnicianData.List(new QueryOptions<Technician>());

            var incident = IncidentData.Get(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident modifiedIncident)
        {
            if (ModelState.IsValid)
            {
                if (modifiedIncident.IncidentId == 0)
                //adding a new incident
                {
                    IncidentData.Insert(modifiedIncident);
                }
                else
                {
                    //updating an existing incident
                    IncidentData.Update(modifiedIncident);
                }
                IncidentData.Save();
                return RedirectToAction("List", "Incident");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedIncident.IncidentId == 0) ? "Add" : "Edit";
                ViewBag.Customers = CustomerData.List(new QueryOptions<Customer>());
                ViewBag.Products = ProductData.List(new QueryOptions<Product>());
                ViewBag.Technicians = TechnicianData.List(new QueryOptions<Technician>());
                return View(modifiedIncident);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = IncidentData.Get(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            IncidentData.Delete(incident);
            IncidentData.Save();
            return RedirectToAction("List", "Incident");
        }
    }
}
