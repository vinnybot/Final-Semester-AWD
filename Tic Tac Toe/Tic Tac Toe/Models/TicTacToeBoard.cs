using System.Security.AccessControl;

namespace Tic_Tac_Toe.Models
{
    public class TicTacToeBoard
    {
        // Initialize list of cells in constuctor. Include 

        public TicTacToeBoard()
        {
            string[] rows = new string[] { "Top", "Middle", "Bottom" };
            string[] cols = new string[] { "Left", "Middle", "Right" };

            Cells = new List<Cell>();

            foreach (string r in rows)
            {
                foreach (string c in cols)
                {
                    Cell cell = new Cell { Id = r + c };
                    Cells.Add(cell);
                }
            }
        }

        public List<Cell> Cells { get; set; }
        public bool HasWinner { get; set; }
        public string WinningMark { get; set; } = string.Empty;

        public bool HasAllCellsSelected { get; set; }

        public void CheckForWinner()
        {
            // reset winner fields before check
            HasWinner = false;
            WinningMark = null!;

            //check top row
            if (IsWinner(Cells[0].Mark, Cells[1].Mark, Cells[2].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[0].Mark;
            }
            //middle row
            else if (IsWinner(Cells[3].Mark, Cells[4].Mark, Cells[5].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[3].Mark;
            }
            //bottom row
            else if (IsWinner(Cells[6].Mark, Cells[7].Mark, Cells[8].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[6].Mark;
            }
            //left column
            else if (IsWinner(Cells[0].Mark, Cells[3].Mark, Cells[6].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[0].Mark;
            }
            //middle column
            else if (IsWinner(Cells[1].Mark, Cells[4].Mark, Cells[7].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[1].Mark;
            }
            // right column
            else if (IsWinner(Cells[2].Mark, Cells[5].Mark, Cells[8].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[2].Mark;
            }
            else if (IsWinner(Cells[0].Mark, Cells[4].Mark, Cells[8].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[0].Mark;
            }
            else if (IsWinner(Cells[2].Mark, Cells[4].Mark, Cells[6].Mark))
            {
                HasWinner = true;
                WinningMark = Cells[2].Mark;
            }

            // check if all cells are marked - set to true to start, then set to false if a cell is blank
            HasAllCellsSelected = true;

            foreach (Cell cell in Cells)
            {
                if (cell.IsBlank)
                {
                    HasAllCellsSelected = false;
                    return;
                }
            }
        }

        private bool IsWinner(string mark1, string mark2, string mark3)
        {
            //all three marks match and they arent null
            return mark1 == mark2 && mark2 == mark3 && !string.IsNullOrEmpty(mark1);
        }
    }
}
