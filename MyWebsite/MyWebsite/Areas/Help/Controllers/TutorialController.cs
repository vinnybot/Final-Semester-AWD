using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        [Area("Help")]
        public IActionResult Index(string id)
        {
            if (id == "Page2")
            {
                return View("Page2");
            }

            if (id == "Page3")
            {
                return View("Page3");
            }

            else
            {
                return View("Page1");
            }
        }
    }
}
