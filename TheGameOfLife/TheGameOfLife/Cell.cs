using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Cell
    {
        public int Collor { get; set; }
        private bool life;

        public bool Life
        {
            get { return life; }
            set { life = value; }
        }
        public Cell(bool Life,int Collor)
        {
            this.life = Life;
            this.Collor = Collor;
        }

    }
}
