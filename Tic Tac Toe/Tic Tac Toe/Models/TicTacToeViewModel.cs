﻿namespace Tic_Tac_Toe.Models
{
    public class TicTacToeViewModel
    {
        public List<Cell> Cells { get; set; } = null!;

        public Cell Selected { get; set; } = null!;

        public bool IsGameOver { get; set; }
    }
}
