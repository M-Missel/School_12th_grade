using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    class Geist : SpielFigur
    {
        private PacMan pacman;

        public Geist(PacMan pPacMan) {
            this.pacman = pPacMan;    
        }

        public void berechneRichtung()
        {
            int deltaX = pacman.gibPosX() - posX;
            int deltaY = pacman.gibPosY() - posY;

            if (Math.Abs(deltaX) > Math.Abs(deltaY))
            {
                if (deltaX > 0)
                    dieRichtung = 1;
                else
                    dieRichtung = 0;
            }
            else
            {
                if(deltaY > 0)
                    dieRichtung = 4;
                else
                {
                    if(deltaY < 0)
                        dieRichtung = 2;
                    else
                        dieRichtung = 0;
                }
            }
        }

        public bool pruefePacManGefressen()
        {
            if (posX == pacman.gibPosX() && posY == pacman.gibPosY())
                return true;
            return false;
        }

        public override void zeichen(ZeichenFlaeche pZF)
        {
            pZF[posX, posY] = "G";
        }
    }
}