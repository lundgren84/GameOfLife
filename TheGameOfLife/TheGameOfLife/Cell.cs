using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Cell
    {
        private int liv;

        public int Liv
        {
            get { return liv; }
            set { liv = value; }
        }
       public Cell(int liv)
        {
            this.Liv = liv;
        }
        public Cell()
        { }
        /// <summary>
        /// Adds a dead cell
        /// </summary>
        /// <returns></returns>
        public Cell ADeadCell()
        {
            Cell cell = new Cell(0);
            return cell;
        }
        /// <summary>
        /// Adds a Living cell
        /// </summary>
        /// <returns></returns>
        public Cell ALivingCell()
        {
            Cell cell = new Cell(1);
            return cell;
        }
        /// <summary>
        /// Putts some random cells to life
        /// </summary>
        /// <param name="GameBoard"></param>
        public Cell[,] GetRandom(Cell[,] GameBoard)
        {

            int go = 20;
            while (go > 0)
            {
                
                int x = GameMethods.Randomize();
                int y = GameMethods.Randomize();

                GameBoard[x, y] = ALivingCell();
                
                go-=1;
            }
            return GameBoard;
        }
        /// <summary>
        ///  Filling gameboard with dead cells
        /// </summary>
        /// <param name="GameBoard"></param>
        /// <param name="cel"></param>
        public Cell[,] FillWithCells(Cell[,] GameBoard )
        {
            
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    Cell cell = ADeadCell();
                    GameBoard[y, x] = cell;
                }
            }
            return GameBoard;
        }
        /// <summary>
        /// Prints gameboard with living cells
        /// </summary>
        /// <param name="GameBoard"></param>
        /// <param name="cell"></param>
        public void PrintBoard(Cell[,] GameBoard, Cell cell)
        {
            
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 50; x++)
                {
                    cell = GameBoard[x, y];
                    if (cell.Liv == 1) { Console.Write("#"); }
                    else if (cell.Liv == 0) { Console.Write("."); }
                    else { Console.Write(" "); }
                }
            }
        }
    }
}
