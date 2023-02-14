using FAQ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FAQ.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx) => context = ctx;

        [Route("topic/{topic}/category/{category}")]
        [Route("topic/{topic}")]
        [Route("category/{category}")]
        [Route("/")]

        public IActionResult Index(string topic, string category)
        {
            ViewBag.Topics = context.Topics.OrderBy(t => t.Name).ToList();
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            ViewBag.SelectedTopic = topic;

            IQueryable<FAQs> faqs = context.FAQs.Include(t => t.Topic).Include(c => c.Category).OrderBy(q => q.Question);

            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(f => f.TopicId == topic);
            }
            if (!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(f => f.CategoryId == category);
            }
            return View(faqs.ToList());
        }

    }
}