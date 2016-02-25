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
            ConsoleColor collor = new ConsoleColor();
            if (ChangeCollor == 1) { collor = ConsoleColor.Yellow; }
            if (ChangeCollor == 2) { collor = ConsoleColor.Green; }
            else { collor = ConsoleColor.Red; }
            return collor; 
        }
    }
}
