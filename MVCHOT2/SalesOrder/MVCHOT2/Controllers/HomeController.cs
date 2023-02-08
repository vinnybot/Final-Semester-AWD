using MVCHOT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCHOT2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SalesOrderModel model)
        {
            return View(model);
        }
    }
}