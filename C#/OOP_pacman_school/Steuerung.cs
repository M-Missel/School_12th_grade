using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman
{
    class Steuerung
    {
        private FressPunkt[] derFressPunkt;
        private Geist[] derGeist;
        private OberFlaeche oberFlaeche;
        private Timer timer;
        private PacMan pacMan;

        public Steuerung(OberFlaeche pOberFlaeche)
        {
            oberFlaeche = pOberFlaeche;

            derFressPunkt = new FressPunkt[135];
            int i = 0;
            for (int x = 0; x <= 14; x++)
            {
                for (int y = 0; y <= 8; y++)
                {
                    derFressPunkt[i] = new FressPunkt(x, y);
                    i++;
                }
            }

            pacMan = new PacMan(derFressPunkt);

            timer = new Timer(this, 1000);

            derGeist = new Geist[4];
            for (int k = 0; k < derGeist.Length; k++)
            {
                derGeist[k] = new Geist(pacMan);
            }
        }

        public void starteSpiel()
        {
            initSpielObjekte();

            timer.starte();
        }

        public void tickTimer(object sender, EventArgs e)
        {
            pacMan.bewege();

            pacMan.aktualisierePunkte();

            for (int i = 0; i < derGeist.Length; i++)
            {
                derGeist[i].berechneRichtung();
                derGeist[i].bewege();
            }

            zeichenSpielObjekte();

            pruefeSpielZustand();
        }

        public void verarbeiteTastenDruck(int pRichtung)
        {
            pacMan.setzteRichtung(pRichtung);
        }

        private void initSpielObjekte()
        {
            int[,] koords = {
                { 0,0},
                { 14,0},
                { 0,8},
                { 14,8},
            };

            pacMan.setztePos(7,4);
            pacMan.setzteRichtung(0);
            pacMan.loeschePunkte();

            for (int i = 0; i < 4; i++)
            {
                derGeist[i].setztePos(koords[i, 0], koords[i, 1]);
            }

            for (int i = 0; i < derFressPunkt.Length; i++)
            {
                derFressPunkt[i].setzteGefressen(false);
            }
        }

        private void zeichenSpielObjekte()
        {
            ZeichenFlaeche zeichenFlaeche =  oberFlaeche.gibZeichenFlaeche();

            for (int i = 0; i < derFressPunkt.Length; i++)
            {
                if (!derFressPunkt[i].gibGefressen())
                    derFressPunkt[i].zeichen(zeichenFlaeche);
                else
                    derFressPunkt[i].zeichnenOhne(zeichenFlaeche);
            }

            pacMan.zeichen(zeichenFlaeche);

            for (int i = 0; i < derGeist.Length; i++)
            {
                derGeist[i].zeichen(zeichenFlaeche);
            }
        }

        private void pruefeSpielZustand()
        {
            bool gefressen = false; ;
            oberFlaeche.schreibePunkte(pacMan.gibPunkte());

            for (int i = 0; i < derGeist.Length; i++)
            {
                gefressen = derGeist[i].pruefePacManGefressen();
            }

            if (gefressen || pacMan.gibPunkte() == 133)
            {
                timer.Stop();
                if (gefressen == false)
                {
                    oberFlaeche.zeigeMeldung($"Gratuliere, Du hast gewonnen");
                }
                else
                {
                    oberFlaeche.zeigeMeldung($"Du hast verloren und {pacMan.gibPunkte()} Punkte erreicht");
                }
            }
            
        }
    }
}
