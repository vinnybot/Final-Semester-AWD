using Chapter_8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chapter_8.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }

        public HomeController(TripContext ctx) => context = ctx;
        public IActionResult Index()
        {
            var trips = context.Trips.ToList();
            return View(trips);
        }
    }
}