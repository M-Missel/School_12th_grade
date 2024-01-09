using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class GameData
    {
        private int[,] gameBoard = new int[7, 7];

        public int gibWert(int xpos, int ypos) => gameBoard[xpos, ypos];

        public void setzeWert(int xpos, int ypos, int newVal) => gameBoard[xpos, ypos] = newVal;
    }
}
