using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    abstract class SpielElement
    {
        protected int posX, posY;

        public int gibPosX()
        {
            return posX;
        }

        public int gibPosY()
        {
            return posY;
        }

        public abstract void zeichen(ZeichenFlaeche pZF);
    }
}
