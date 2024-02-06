using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    class FressPunkt : SpielElement
    {
        private bool gefressen;

        public FressPunkt(int pPosX, int pPosY)
        {
            this.posX = pPosX;
            this.posY = pPosY;
            this.gefressen = false;
        }

        public bool gibGefressen()
        {
            return gefressen;
        }

        public void setzteGefressen(bool pGefressen)
        {
            this.gefressen = pGefressen;
        }

        public override void zeichen(ZeichenFlaeche pZF)
        {
            pZF[posX, posY] = "X";
        }

        public void zeichnenOhne(ZeichenFlaeche pZF)
        {
            pZF[posX, posY] = " ";
        }
    }
}
