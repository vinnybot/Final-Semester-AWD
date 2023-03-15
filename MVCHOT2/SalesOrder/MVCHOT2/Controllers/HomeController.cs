using MVCHOT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCHOT2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}