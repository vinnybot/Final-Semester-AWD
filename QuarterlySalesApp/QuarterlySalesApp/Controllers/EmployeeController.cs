using Microsoft.AspNetCore.Mvc;
using QuarterlySalesApp.Models;
using QuarterlySalesApp.Models.Validation;

namespace QuarterlySalesApp.Controllers
{
    public class EmployeeController : Controller
    {
        private QuarterlyContext context { get; set; }
        public EmployeeController(QuarterlyContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = context.Employees.OrderBy(x => x.Name).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            //server side checks for remote validation
            string msg = Validate.CheckEmployee(context, employee);
            if (!string.IsNullOrEmpty(msg))
            {
                ModelState.AddModelError(nameof(Employee.DOB), msg);
            }

            msg = Validate.CheckManagerEmployeeMatch(context, employee);
            if (!string.IsNullOrEmpty(msg))
            {
                ModelState.AddModelError(nameof(Employee.ManagerId), msg);
            }

            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                TempData["message"] = $"Employee {employee.FullName} Added";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Employees = context.Employees.OrderBy(e => e.Name).ToList();
                return View();
            }
        }
    }
}
