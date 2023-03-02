using Microsoft.AspNetCore.Mvc;
using Teams.Models;

namespace Teams.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public RedirectToActionResult Add(Team team) 
        {
            //Code here in ch.9   
            TempData["message"] = $"{team.Name} added to your favorites";
            
            return RedirectToAction("Index", "Home");

        }
    }
}
