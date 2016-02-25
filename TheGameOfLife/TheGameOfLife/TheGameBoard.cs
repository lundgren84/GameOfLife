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
        int X = 100;
        int Y = 25;
        string PrintedGame = String.Empty;
        public TheGameBoard()
        {
            this.GameBoard = new Cell[Console.WindowHeight, Console.WindowWidth];
        }
        public void FillBoard()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    Cell cell = new Cell(false, 1, 0);
                    GameBoard[y, x] = cell;
                }
            }
        }
        public void PutRandomCellToLife()
        {
            int go = 0;
            Random random = new Random();
            while (go< 2000)
            {
                int y = random.Next(0, Y);
                int x = random.Next(0, X);

                GameBoard[y, x].Life = true;
                go++;
            }
        }
        public void ReadBoard()
        {
             PrintedGame = String.Empty;
            Console.Clear();
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if (GameBoard[y, x].Life == true) { ConsoleColor Olle = Methods.CollorChanger(GameBoard[y, x].Color); Console.BackgroundColor = Olle; PrintedGame +="O"; Console.BackgroundColor = ConsoleColor.Black; ; }
                    else if (GameBoard[y, x].Life == false) { PrintedGame += " "; }
                }
                PrintedGame += "\n";
            }
            Console.Write(PrintedGame);
        }
        public void PrintBoard()
        { Console.Write(PrintedGame); }
        public void NextDoorCell()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    GameBoard[y, x]._nextDoor = 0;
                    if (y != 0 && GameBoard[y - 1, x].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (y != 0 && x != X - 1 && GameBoard[y - 1, x + 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (y != 0 && x != 0 && GameBoard[y - 1, x - 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (y != Y - 1 && GameBoard[y + 1, x].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (y != Y - 1 && x != X - 1 && GameBoard[y + 1, x + 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (y != Y - 1 && x != 0 && GameBoard[y + 1, x - 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (x != X - 1 && GameBoard[y, x + 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                    if (x != 0 && GameBoard[y, x - 1].Life == true) { GameBoard[y, x]._nextDoor += 1; }
                }
            }

        }
        public void ChangeBoard()
        {
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if (GameBoard[y, x].Life == true && GameBoard[y, x]._nextDoor == 3) { GameBoard[y, x].Color = +1; }
                    else if (GameBoard[y, x].Life == true && GameBoard[y, x]._nextDoor == 2) { GameBoard[y, x].Color += 1; }
                    else if (GameBoard[y, x].Life == true && GameBoard[y, x]._nextDoor < 2 || GameBoard[y, x]._nextDoor > 3) { GameBoard[y, x].Life = false; GameBoard[y, x].Color = 1; }
                    else if (GameBoard[y, x].Life == false && GameBoard[y, x]._nextDoor == 3) { GameBoard[y, x].Life = true; }
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
        public void GliderGun20(int a,int b)
        {         
            GameBoard[a + 0, b + 0].Life = true;
            GameBoard[a + 1, b + 0].Life = true;
            GameBoard[a + 11, b + 1].Life = true;
            GameBoard[a + 10, b + 1].Life = true;

            GameBoard[a + 15, b + 1].Life = true;
            GameBoard[a + 15, b + 2].Life = true;
            GameBoard[a + 16, b + 1].Life = true;
            GameBoard[a + 16, b + 2].Life = true;

            GameBoard[a + 15, b + 11].Life = true;
            GameBoard[a + 16, b + 11].Life = true;
            GameBoard[a + 17, b + 11].Life = true;
            GameBoard[a + 14, b + 12].Life = true;
            GameBoard[a + 18, b + 12].Life = true;
            GameBoard[a + 13, b + 13].Life = true;
            GameBoard[a + 19, b + 13].Life = true;
            GameBoard[a + 13, b + 14].Life = true;
            GameBoard[a + 19, b + 14].Life = true;
            GameBoard[a + 16, b + 15].Life = true;
            GameBoard[a + 14, b + 16].Life = true;
            GameBoard[a + 18, b + 16].Life = true;
            GameBoard[a + 15, b + 17].Life = true;
            GameBoard[a + 16, b + 17].Life = true;
            GameBoard[a + 17, b + 17].Life = true;
            GameBoard[a + 16, b + 18].Life = true;
            GameBoard[a + 13, b + 21].Life = true;
            GameBoard[a + 14, b + 21].Life = true;
            GameBoard[a + 15, b + 21].Life = true;
            GameBoard[a + 13, b + 22].Life = true;
            GameBoard[a + 14, b + 22].Life = true;
            GameBoard[a + 15, b + 22].Life = true;
            GameBoard[a + 12, b + 23].Life = true;
            GameBoard[a + 16, b + 23].Life = true;
            GameBoard[a + 11, b + 25].Life = true;
            GameBoard[a + 12, b + 25].Life = true;
            GameBoard[a + 16, b + 25].Life = true;
            GameBoard[a + 17, b + 25].Life = true;

            GameBoard[a + 13, b + 35].Life = true;
            GameBoard[a + 14, b + 35].Life = true;
            GameBoard[a + 13, b + 36].Life = true;
            GameBoard[a + 14, b + 36].Life = true;
        }
        public void GliderGun()
        {
            GameBoard[0, 0].Life = true;
            GameBoard[1, 0].Life = true;
            GameBoard[1, 1].Life = true;
            GameBoard[0, 1].Life = true;

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
        public void SpaceShip()
        {

            GameBoard[1, 3].Life = true;
            GameBoard[2, 3].Life = true;
            GameBoard[3, 3].Life = true;
            GameBoard[3, 2].Life = true;
            GameBoard[2, 1].Life = true;
        }

    }
}
