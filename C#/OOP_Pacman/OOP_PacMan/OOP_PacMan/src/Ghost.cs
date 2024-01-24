using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PacMan.src
{
    class Ghost : GameFigure
    {
        private PacMan pacMan;

        public Ghost(PacMan pacMan)
        {
            this.pacMan = pacMan;
        }

        public void calcDirection() { }

        public bool controllPacManEaten()
        {
            throw new NotImplementedException();
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }
    }
}
