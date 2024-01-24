using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PacMan.src
{
    abstract class GameFigure : GameElement
    {
        protected int direction;

        public void setPos(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void move() { }

        public bool samePos(int posX, int posY)
        {
            throw new NotImplementedException();
        }
    }
}
