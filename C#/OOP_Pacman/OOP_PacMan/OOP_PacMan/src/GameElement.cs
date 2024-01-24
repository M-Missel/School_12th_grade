using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PacMan.src
{
    abstract class GameElement
    {
        protected int posX, posY;

        public int PosX {
            get => posX;
        }

        public int PosY
        {
            get => posY;
        }

        public abstract void draw(); 
    }
}
