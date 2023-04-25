using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MVCHOT2.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
