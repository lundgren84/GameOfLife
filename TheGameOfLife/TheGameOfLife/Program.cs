using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Program
    {
        public void NextBoard(Cell[,] GameBoard)
        {
            int die = 0;
            int live = 0;
            int y = 0;
            int x = 0;
            for (y = 0; y < 100; y++)
            {
                for (x = 0; x < 100; x++)
                {
                    if (GameBoard[y, x].Life == true)
                    {
                        if (y > 0 && GameBoard[y - 1, x].Life == true) { live++; }
                        if (y > 0 && x < 99 && GameBoard[y - 1, x + 1].Life == true) { live++; }
                        if (y > 0 && x > 0 && GameBoard[y - 1, x - 1].Life == true) { live++; }
                        if (y < 99 && GameBoard[y + 1, x].Life == true) { live++; }
                        if (y < 99 && x < 99 && GameBoard[y + 1, x + 1].Life == true) { live++; }
                        if (y < 99 && x > 0 && GameBoard[y + 1, x - 1].Life == true) { live++; }
                        if (x < 99 && GameBoard[y, x + 1].Life == true) { live++; }
                        if (x > 0 && GameBoard[y, x - 1].Life == true) { live++; }

                        if (live == 2 || live == 3) { GameBoard[y, x].Life = true; }
                        if (live < 2) { GameBoard[y, x].Life = false; }
                        if (live > 3) { GameBoard[y, x].Life = false; }
                    }
                    if (GameBoard[y, x].Life == false)
                    {
                        if (y > 0 && GameBoard[y - 1, x].Life == true) { die++; }
                        if (y > 0 && x < 99 && GameBoard[y - 1, x + 1].Life == true) { die++; }
                        if (y > 0 && x > 0 && GameBoard[y - 1, x - 1].Life == true) { die++; }
                        if (y < 99 && GameBoard[y + 1, x].Life == true) { die++; }
                        if (y < 99 && x < 99 && GameBoard[y + 1, x + 1].Life == true) { die++; }
                        if (y < 99 && x > 0 && GameBoard[y + 1, x - 1].Life == true) { die++; }
                        if (x < 99 && GameBoard[y, x + 1].Life == true) { die++; }
                        if (x > 0 && GameBoard[y, x - 1].Life == true) { die++; }

                        if (die == 3) { GameBoard[y, x].Life = true; }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            
            TheGameBoard thegameboard = new TheGameBoard();
            thegameboard.FillBoard();
            //thegameboard.PutRandomCellToLife();
            thegameboard.AddACellZone();

            Console.WriteLine("Press a key to start Game Of Life");
            Console.ReadKey();

            DateTime now = new DateTime();
            now = DateTime.Now;
            while (true)
            {
                 while (now < DateTime.Now)
                {
                    Console.Clear();
                    thegameboard.PrintBoard();                   
                    thegameboard.NextBoard();

                    now = DateTime.Now.AddSeconds(0.2);
              
                }
            }
        }
    }
}
