using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_racing
{
    internal class Horse
    {
        private int pos;
        private int nr;

        public Horse(int nr)
        {
            pos = 0;
            this.nr = nr;
        }

        public void move()
        {
            pos++;
        }

        public int getPos() => pos;
    }
}
