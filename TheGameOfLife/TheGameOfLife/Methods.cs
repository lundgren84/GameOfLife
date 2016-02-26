using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    public static class Methods
    {
        public static ConsoleColor CollorChanger(int ChangeCollor)
        {
            ConsoleColor color = new ConsoleColor();
            if (ChangeCollor == 1) { color = ConsoleColor.Red; }
           
            else { color = ConsoleColor.DarkRed; }
            return color; 
        }
        public static void Menu()
        {
            Console.WriteLine("Start Menu");
            Console.WriteLine("1. \n###\n# #\n###");
            Console.WriteLine();
        }
    }
}
