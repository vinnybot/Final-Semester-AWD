using Chapter_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
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
