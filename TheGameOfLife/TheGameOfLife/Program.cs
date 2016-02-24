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
            Cell[,] GameBoard = new Cell[50, 50];
            GameBoard = cell.FillWithCells(GameBoard);
            //-----------------------------------------------


            GameBoard = cell.GetRandom(GameBoard);
            cell.PrintBoard(GameBoard, cell);

            Console.ReadKey();
        }
    }
}
