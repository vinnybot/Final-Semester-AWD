using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tic_Tac_Toe.Models;

namespace Tic_Tac_Toe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public ViewResult Index()
        {
            var board = new TicTacToeBoard();

            foreach (Cell cell in board.Cells)
            {
                cell.Mark = TempData[cell.Id]?.ToString()!;
            }
            board.CheckForWinner();

            //create view model to pass to view
            var model = new TicTacToeViewModel
            {
                Cells = board.Cells,
                Selected = new Cell { Mark = TempData["nextTurn"]?.ToString() ?? "X" }, // add default
                IsGameOver = board.HasWinner || board.HasAllCellsSelected
            };

            if (model.IsGameOver) 
            {
                TempData["nextTurn"] = "X"; //reset mark
                TempData["message"] = (board.HasWinner) ? $"{board.WinningMark} wins!" : "It's a tie!";
            }
            else
            {
                //game continues
                TempData.Keep();
            }
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Index(TicTacToeViewModel vm)
        {
            // store selected cell in TempData
            TempData[vm.Selected.Id] = vm.Selected.Mark;

            //determine next turn based on current mark and store in TempData
            TempData["nextTurn"] = (vm.Selected.Mark == "X") ? "O" : "X";

            return RedirectToAction("Index");
        }
    }
}