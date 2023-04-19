using Microsoft.AspNetCore.Mvc;
using QuarterlySalesApp.Models;
using QuarterlySalesApp.Models.Validation;

namespace QuarterlySalesApp.Controllers
{
    public class ValidationController : Controller
    {
        private QuarterlyContext context { get; set; }
        public ValidationController(QuarterlyContext ctx) => context = ctx;


        public JsonResult CheckEmployee(string Name, string LastName, DateTime DOB)
        {
            Employee employee = new Employee { Name = Name, LastName = LastName, DOB = DOB };

            string msg = Validate.CheckEmployee(context, employee);

            if (string.IsNullOrEmpty(msg))
            {
                return Json(true);
            }
            else
            {
                return Json(msg);
            }
        }

        public JsonResult CheckManager(int managerId, string firstname, string lastname, DateTime dob)
        {
            var employee = new Employee{ Name = firstname, LastName = lastname, ManagerId = managerId, DOB = dob };

        string msg = Validate.CheckManagerEmployeeMatch(context, employee);

        if (string.IsNullOrEmpty(msg))
            {
                return Json(true);
            } else
            {
                return Json(msg);
            }
        }

        public JsonResult CheckSales(int quarter, int year, int employeeId)
        {
            var sales = new Sale { Quarter = quarter, EmployeeId = employeeId, Year = year };
            string msg = Validate.CheckSales(context, sales);

            if (string.IsNullOrEmpty(msg))
            {
                return Json(true);
            } 
            else
            {
                return Json(msg);
            }
        }
    }
}
