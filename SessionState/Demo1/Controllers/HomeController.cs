using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //Read from session variables called "num"
            int? num = HttpContext.Session.GetInt32("num");
            if (num == null)
            {
                num = 1;
            }
            else
            {
                num += 1;
            }
            HttpContext.Session.SetInt32("num", (int)num!);

            return View();
        }
    }
}