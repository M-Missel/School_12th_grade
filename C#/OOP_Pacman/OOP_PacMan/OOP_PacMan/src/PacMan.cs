using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PacMan.src
{
    class PacMan : GameFigure
    {
        int points;

        public PacMan(int posX, int posY, int direction) {
            this.posX = posX;
            this.posY = posY;
            this.direction = direction;
        }

        public int Direction
        {
            set => direction = value;
        }

        public void deletePoint() { }

        public void updatePoints() { }

        public override void draw()
        {
            throw new NotImplementedException();
        }
    }
}
