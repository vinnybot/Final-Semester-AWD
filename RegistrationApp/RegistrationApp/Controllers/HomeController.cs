using Microsoft.AspNetCore.Mvc;

namespace RegistrationApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}