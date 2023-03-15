using Microsoft.AspNetCore.Mvc;
using PIG.Models;
using System.Diagnostics;

namespace PIG.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // get game object from session
            var sess = new GameSession(HttpContext.Session);
            var game = sess.GetGame();

            // notify if there's a winner

            if (game.IsGameOver)
            {
                TempData["message"] = $"{game.CurrentPlayerName} wins!";
            }

            // pass game object to view
            return View(game);
        }

        [HttpPost]
        public IActionResult NewGame()
        {
            //get game object from session

            var sess = new GameSession(HttpContext.Session);
            var game = sess.GetGame();

            game.NewGame();

            sess.SetGame(game);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult Roll()
        {
            var sess = new GameSession(HttpContext.Session);
            var game = sess.GetGame();

            game.Roll();

            sess.SetGame(game);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult Hold()
        {
            var sess = new GameSession(HttpContext.Session);
            var game = sess.GetGame();

            game.Hold();

            sess.SetGame(game);
            return RedirectToAction("Index");
        }
    }
}