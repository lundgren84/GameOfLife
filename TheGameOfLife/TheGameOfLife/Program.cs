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
            int[,] GameBoard = new int[100, 100];
            GameMethods gamemethods = new GameMethods();
            gamemethods.GetRandom(GameBoard);
            gamemethods.PrintBoard(GameBoard);
            Console.ReadKey();
        }
    }
}
