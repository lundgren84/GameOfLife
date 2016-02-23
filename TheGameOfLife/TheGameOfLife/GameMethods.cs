using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class GameMethods
    {
        Random random = new Random();
        public void PrintBoard(int[,] GameBoard)
        {

            for (int y = 0; y < 100; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    if (GameBoard[x, y] == 1) { Console.Write("¤"); }
                    else { Console.Write(" "); }
                }
            }
        }
        /// <summary>
        /// Adds Cells to game
        /// </summary>
        /// <param name="GameBoard"></param>
        public void GetRandom(int[,] GameBoard)
        {
            int WhileGo = 0;
            while (WhileGo < 20)
            {
                int X = random.Next(0, 100);
                int Y = random.Next(0, 100);
                GameBoard[X, Y] = 1;
                WhileGo++;
            }
        }
    }
}
