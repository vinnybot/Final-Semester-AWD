using Microsoft.AspNetCore.Mvc;
using QuarterlySalesApp.Models;
using QuarterlySalesApp.Models.Validation;

namespace QuarterlySalesApp.Controllers
{
    public class SaleController : Controller
    {
        private QuarterlyContext context;
        public SaleController(QuarterlyContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = context.Employees.OrderBy(x => x.LastName).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Sale sale)
        {
            string msg = Validate.CheckSales(context, sale);

            if (!string.IsNullOrEmpty(msg))
            {
                ModelState.AddModelError(nameof(Sale.EmployeeId), msg);
            }

            if (ModelState.IsValid)
            {
                context.Sales.Add(sale);
                context.SaveChanges();
                TempData["message"] = "Sale Added!";
                return RedirectToAction("Index", "Home");
            } else
            {
                //data is invalid
                ViewBag.Employees = context.Employees.OrderBy(x => x.LastName).ToList();
                return View();
            }
        }
    }
}
