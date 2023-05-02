using Chapter_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_3.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CaseStudyModel model)
        {
            return View(model);
        }
    }
}