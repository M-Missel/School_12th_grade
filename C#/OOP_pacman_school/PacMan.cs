using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    class PacMan : SpielFigur
    {
        private int diePunkte;
        private FressPunkt[] derFressPunkt;

        public PacMan(FressPunkt[] FressPunkt)
        {
            this.derFressPunkt = FressPunkt;
        }

        public void setzteRichtung(int pRichtung)
        {
            this.dieRichtung = pRichtung;
        }

        public void loeschePunkte()
        {
            diePunkte = 0;
        }

        public void aktualisierePunkte()
        {
            int posX, posY;
            for (int i = 0; i < derFressPunkt.Length; i++)
            {
                posX = derFressPunkt[i].gibPosX();
                posY = derFressPunkt[i].gibPosY();

                if (hatGleichePos(posX, posY))
                {
                    if (!derFressPunkt[i].gibGefressen())
                    {
                        derFressPunkt[i].setzteGefressen(true);
                        diePunkte++;
                    }
                }
            }
        }

        public override void zeichen(ZeichenFlaeche pZF)
        {
            pZF[posX, posY] = "C";
        }

        public int gibPunkte()
        {
            return diePunkte;
        }
    }
}
