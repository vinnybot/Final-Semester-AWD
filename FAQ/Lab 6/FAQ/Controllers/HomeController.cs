using Microsoft.AspNetCore.Mvc;
using FAQ.Models;
using System.Diagnostics;

namespace FAQ.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx) => context = ctx;
        public IActionResult Index(string category, string topic)
        {
            var faqs = context.FAQs.OrderBy(x => x.Id).ToList();
            ViewBag.Topics = context.Topics.OrderBy(t => t.Name).ToList();
            ViewBag.Categories = context.Categories.OrderBy(t => t.Name).ToList();

            return View(faqs);
        }
    }
}