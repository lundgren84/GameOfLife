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
            Cell cell = new Cell();
            Cell[,] GameBoard = new Cell[100, 100];
            GameMethods gamemethods = new GameMethods();
            gamemethods.GetRandom(GameBoard,cell);
            gamemethods.PrintBoard(GameBoard,cell);
            Console.ReadKey();
        }
    }
}
