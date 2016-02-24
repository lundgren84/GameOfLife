using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
   public static class Methods
    {
        public static int CheckNr(int x,int y)
        {
            if (x < 0) { x = 0; }
            if (y < 0) { y = 0; }
            if (x > 100) { x = 100; }
            if (y > 100) { y = 100; }
            return x;
        }
    }
}
