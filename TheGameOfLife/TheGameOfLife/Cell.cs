using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLife
{
    class Cell
    {
        public int _nextDoor { get; set; }
        public int Color { get; set; }
        private bool life;

        public bool Life
        {
            get { return life; }
            set { life = value; }
        }
        public Cell(bool Life,int Collor,int _nextDoor)
        {
            this.life = Life;
            this.Color = Collor;
            this._nextDoor = _nextDoor;
        }

    }
}
