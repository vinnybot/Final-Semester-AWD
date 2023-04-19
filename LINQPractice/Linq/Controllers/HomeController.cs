using Linq.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Linq.Controllers
{
    public class HomeController : Controller
    {
        private HenryContext context { get; set; }

        public HomeController(HenryContext ctx) => context = ctx;

        public IActionResult Index()
        {
            List<Publisher> publishers = context.Publishers.OrderBy(p => p.PublisherName).ToList();
            return View(publishers);
        }

        [HttpGet]
        public IActionResult NumOne()
        {
            //projection with an anonymous type
            var books = context.Books.Select(b => new BookDTO
            {
                BookCode = b.BookCode,
                Title = b.Title
            }).ToList();
            return View(books);
        }
        [HttpGet]
        public IActionResult NumThree() 
        {
            var publishers =
                context.Publishers
                .Where(p => p.City == "Boston")
                .Select(p => new PublisherNameDTO { PublisherName = p.PublisherName, City = p.City })
                .ToList();
            return View(publishers);
        }
        [HttpGet]
        public IActionResult NumFour() 
        {
            var publishers = context.Publishers
                .Where(p => p.City != "Boston")
                .Select(p => new PublisherNameDTO { PublisherName = p.PublisherName, City = p.City })
                .ToList();
            return View(publishers);
        }
        [HttpGet]
        public IActionResult NumFive()
        {
            var branch = context.Branches
            .Where(b => b.NumEmployees > 9)
            .ToList();
            return View(branch);
        }
    }
}