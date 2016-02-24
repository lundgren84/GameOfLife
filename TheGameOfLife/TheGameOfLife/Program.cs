using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGameBoard thegameboard = new TheGameBoard();
            thegameboard.FillBoard();
            thegameboard.PutRandomCellToLife();
            thegameboard.AddACellZone();

            DateTime now = new DateTime();
            now = DateTime.Now;

            while (now < DateTime.Now)
            {
                thegameboard.PrintBoard();
                thegameboard.NextBoard();
                Console.ReadKey();
                now.AddMilliseconds(300);
            }
        }
    }
}
