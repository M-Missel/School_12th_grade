using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class SnakePart
    {
        int x, y;

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y; 
            set => y = value;
        }

        public SnakePart(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool isAt(int x, int y)
        {
            return (this.X == x && this.Y == y);
        }

    }

}
