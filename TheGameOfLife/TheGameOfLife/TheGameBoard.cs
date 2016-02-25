using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    public class TheGameBoard
    {
        Cell[,] GameBoard;

        public TheGameBoard()
        {
            this.GameBoard = new Cell[50, 100];
        }
        public void FillBoard()
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    Cell cell = new Cell(false, 1);
                    GameBoard[y, x] = cell;
                }
            }
        }
        public void PutRandomCellToLife()
        {
            Random random = new Random();
            int go = 0;
            while (go < 3000)
            {
                int x = random.Next(0, 100);
                int y = random.Next(0, 50);
                GameBoard[y, x].Life = true;
                go++;
            }
        }
        public void PrintBoard()
        {
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 100; x++)
                {     
                    if (GameBoard[y, x].Life == true) { ConsoleColor Olle = Methods.CollorChanger(GameBoard[y, x].Collor); Console.ForegroundColor = Olle; Console.Write("O"); Console.ForegroundColor = ConsoleColor.White; GameBoard[y, x].Collor++; }
                    else if (GameBoard[y, x].Life == false) { Console.Write(" "); } 
                }
                Console.Write("\n");
            }
        }
        public void NextBoard()
        {
            int y = 0;
            int x = 0;
            for (y = 0; y < 50; y++)
            {
                for (x = 0; x < 100; x++)
                {
                    if (GameBoard[y, x].Life == true)
                    {
                        int live = 0;
                        if (y != 0 && GameBoard[y - 1, x].Life == true) { live++; }
                        if (y != 0 && x != 99 && GameBoard[y - 1, x + 1].Life == true) { live++; }
                        if (y != 0 && x != 0 && GameBoard[y - 1, x - 1].Life == true) { live++; }
                        if (y != 49 && GameBoard[y + 1, x].Life == true) { live++; }
                        if (y != 49 && x != 99 && GameBoard[y + 1, x + 1].Life == true) { live++; }
                        if (y != 49 && x != 0 && GameBoard[y + 1, x - 1].Life == true) { live++; }
                        if (x != 99 && GameBoard[y, x + 1].Life == true) { live++; }
                        if (x != 0 && GameBoard[y, x - 1].Life == true) { live++; }

                        if (live == 2 || live == 3) { GameBoard[y, x].Life = true; }
                        if (live < 2) { GameBoard[y, x].Life = false; GameBoard[y, x].Collor = 1; }
                        if (live > 3) { GameBoard[y, x].Life = false; GameBoard[y, x].Collor = 1; }

                    }
                    if (GameBoard[y, x].Life == false)
                    {
                        int die = 0;
                        if (y != 0 && GameBoard[y - 1, x].Life == true) { die++; }
                        if (y != 0 && x != 99 && GameBoard[y - 1, x + 1].Life == true) { die++; }
                        if (y != 0 && x != 0 && GameBoard[y - 1, x - 1].Life == true) { die++; }
                        if (y != 49 && GameBoard[y + 1, x].Life == true) { die++; }
                        if (y != 49 && x != 99 && GameBoard[y + 1, x + 1].Life == true) { die++; }
                        if (y != 49 && x != 0 && GameBoard[y + 1, x - 1].Life == true) { die++; }
                        if (x != 99 && GameBoard[y, x + 1].Life == true) { die++; }
                        if (x != 0 && GameBoard[y, x - 1].Life == true) { die++; }

                        if (die == 3) { GameBoard[y, x].Life = true; }
                    }
                }
            }

        }
        public void AddACellZone()
        {
            GameBoard[5, 5].Life = true;
            GameBoard[5, 6].Life = true;
            GameBoard[5, 7].Life = true;
            GameBoard[6, 5].Life = true;

            GameBoard[6, 7].Life = true;
            GameBoard[7, 5].Life = true;
            GameBoard[7, 6].Life = true;
            GameBoard[7, 7].Life = true;
        }




    }
}
