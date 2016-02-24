using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
   public static class GameMethods
    {
       public static int Randomize()
        {
            Random random = new Random();
           int tal = random.Next(0, 50);
            return tal;
        }
        
        
       
        
       
       
    }
}
