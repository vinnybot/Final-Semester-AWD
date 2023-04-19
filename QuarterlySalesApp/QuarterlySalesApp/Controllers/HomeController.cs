using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuarterlySalesApp.Models;
using System.Diagnostics;

namespace QuarterlySalesApp.Controllers
{
    public class HomeController : Controller
    {
        private QuarterlyContext context { get; set; }
        public HomeController(QuarterlyContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index(int id)
        {
            IQueryable<Sale> query = context.Sales.Include(s => s.Employee).OrderBy(s => s.Year);

            if (id > 0)
            {
                query = query.Where(s => s.EmployeeId == id);
            }

            SalesListViewModel vm = new SalesListViewModel
            {
                Sales = query.ToList(),
                Employees = context.Employees.OrderBy(e => e.Name).ToList(),
                EmployeeId = id
            };
            return View(vm);
        }

        [HttpPost]
        public RedirectToActionResult Index(Employee employee)
        {
            //use empty string if no employee id to clear any previous values
            string id = (employee.EmployeeId > 0) ? employee.EmployeeId.ToString() : "";
            return RedirectToAction("Index", new {id} );
        }
    }
}