using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Cell
    {
        private bool life;

        public bool Life
        {
            get { return life; }
            set { life = value; }
        }
        public Cell(bool Life)
        { this.life = Life; }

    }
}
