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
            this.GameBoard = new Cell[25, 50];
        }
        public void FillBoard()
        {
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
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
                int x = random.Next(0, 50);
                int y = random.Next(0, 25);
                GameBoard[y, x].Life = true;
                go++;
            }
        }
        public void PrintBoard()
        {
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 50; x++)
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
            for (y = 0; y < 25; y++)
            {
                for (x = 0; x < 50; x++)
                {
                    if (GameBoard[y, x].Life == true)
                    {
                        int live = 0;
                        if (y != 0 && GameBoard[y - 1, x].Life == true) { live++; }
                        if (y != 0 && x != 49 && GameBoard[y - 1, x + 1].Life == true) { live++; }
                        if (y != 0 && x != 0 && GameBoard[y - 1, x - 1].Life == true) { live++; }
                        if (y != 24 && GameBoard[y + 1, x].Life == true) { live++; }
                        if (y != 24 && x != 49 && GameBoard[y + 1, x + 1].Life == true) { live++; }
                        if (y != 24 && x != 0 && GameBoard[y + 1, x - 1].Life == true) { live++; }
                        if (x != 49 && GameBoard[y, x + 1].Life == true) { live++; }
                        if (x != 0 && GameBoard[y, x - 1].Life == true) { live++; }

                        if (live == 2 || live == 3) { GameBoard[y, x].Life = true; }
                        if (live < 2) { GameBoard[y, x].Life = false; GameBoard[y, x].Collor = 1; }
                        if (live > 3) { GameBoard[y, x].Life = false; GameBoard[y, x].Collor = 1; }

                    }
                    if (GameBoard[y, x].Life == false)
                    {
                        int die = 0;
                        if (y != 0 && GameBoard[y - 1, x].Life == true) { die++; }
                        if (y != 0 && x != 49 && GameBoard[y - 1, x + 1].Life == true) { die++; }
                        if (y != 0 && x != 0 && GameBoard[y - 1, x - 1].Life == true) { die++; }
                        if (y != 24 && GameBoard[y + 1, x].Life == true) { die++; }
                        if (y != 24 && x != 49 && GameBoard[y + 1, x + 1].Life == true) { die++; }
                        if (y != 24 && x != 0 && GameBoard[y + 1, x - 1].Life == true) { die++; }
                        if (x != 49 && GameBoard[y, x + 1].Life == true) { die++; }
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
        public void GliderGun()
        {
            GameBoard[5, 1].Life = true;
            GameBoard[5, 2].Life = true;
            GameBoard[6, 1].Life = true;
            GameBoard[6, 2].Life = true;
            GameBoard[5, 11].Life = true;
            GameBoard[6, 11].Life = true;
            GameBoard[7, 11].Life = true;
            GameBoard[4, 12].Life = true;
            GameBoard[8, 12].Life = true;
            GameBoard[3, 13].Life = true;
            GameBoard[9, 13].Life = true;
            GameBoard[3, 14].Life = true;
            GameBoard[9, 14].Life = true;
            GameBoard[6, 15].Life = true;
            GameBoard[4, 16].Life = true;
            GameBoard[8, 16].Life = true;
            GameBoard[5, 17].Life = true;
            GameBoard[6, 17].Life = true;
            GameBoard[7, 17].Life = true;
            GameBoard[6, 18].Life = true;
            GameBoard[3, 21].Life = true;
            GameBoard[4, 21].Life = true;
            GameBoard[5, 21].Life = true;
            GameBoard[3, 22].Life = true;
            GameBoard[4, 22].Life = true;
            GameBoard[5, 22].Life = true;
            GameBoard[2, 23].Life = true;
            GameBoard[6, 23].Life = true;
            GameBoard[1, 25].Life = true;
            GameBoard[2, 25].Life = true;
            GameBoard[6, 25].Life = true;
            GameBoard[7, 25].Life = true;
            GameBoard[3, 35].Life = true;
            GameBoard[4, 35].Life = true;
            GameBoard[3, 36].Life = true;
            GameBoard[4, 36].Life = true;
        }


    }
}
