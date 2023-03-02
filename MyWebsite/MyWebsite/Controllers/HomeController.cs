using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contact = new Dictionary<string, string>
            {
                { "Phone", "555-123-4567"  },
                { "Email", "me@mywebsite.com" },
                { "Facebook", "facebook.com/mywebsite" }
            };
            return View(contact);
        }

    }
}