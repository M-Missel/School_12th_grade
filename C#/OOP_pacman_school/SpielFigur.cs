using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    abstract class SpielFigur : SpielElement
    {
        protected int dieRichtung;

        public void setztePos(int pPosX, int pPosY)
        {
            this.posX = pPosX;
            this.posY = pPosY;
        }

        public void bewege()
        {
            switch (dieRichtung)
            {
                case 1: posX = Math.Min(++posX, 14); break;
                case 2: posY = Math.Max(--posY, 0); break;
                case 3: posX = Math.Max(--posX, 0); break;
                case 4: posY = Math.Min(++posY, 8); break;
                default: break;
            }
        }

        public bool hatGleichePos(int pPosX, int pPosY)
        {
            if(pPosX == this.posX && pPosY == this.posY)
                return true; 
            return false;
        }
    }
}