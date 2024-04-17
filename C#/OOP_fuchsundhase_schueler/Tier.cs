using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase
{
    public enum TierArt { NONE, FUCHS, HASE }
    public enum Richtung { OST, NORD, WEST, SUED }

    abstract class Tier
    {
        protected int xPos, yPos;
        protected TierArt dieArt;
        protected int dasFutter;
        protected int maxAlter;
        protected int futterMengeNachwuchs;
        protected int gebDat;
        protected Welt dieWelt;

        public Tier(int pX, int pY, Welt pWelt)
        {
            this.xPos = pX;
            this.yPos = pY;
            dieWelt = pWelt;
        }

        public int gibXPos()
        {
            return xPos;
        }

        public int gibYPos()
        {
            return yPos;
        }

        public TierArt gibArt()
        {
            return dieArt;
        }

        public int gibFutter()
        {
            return dasFutter;
        }

        public Richtung gibZufaelligeRichtung()
        {
            Random random = new Random();

            int rand = random.Next(0,4);

            switch (rand)
            {
                case 0:
                    return Richtung.OST;
                    break;
                case 1:
                    return Richtung.NORD;
                    break;
                case 2:
                    return Richtung.WEST;
                    break;
                default:
                    return Richtung.SUED;
            }
        }

        public void loescheZeichend()
        {
            ZeichenFlaeche zf = dieWelt.holeZeichenFlaeche();

            zf[xPos, yPos] = " ";
        }

        public abstract void entwickle();

        public abstract bool pruefeLebensBedingung();

        protected void bewege(Richtung richtung)
        {
            int x1 = this.xPos;
            int y1 = this.yPos;                // ungünstiges Sequenzdiagramm:
            switch (richtung)
            {                // Zielkoordinaten wurden schon in 
                case Richtung.OST: x1++; break; // pruefeBewegung() berechnet, dort
                case Richtung.NORD: y1--; break; // aber nicht gespeichert!
                case Richtung.WEST: x1--; break; // Deshalb muss hier eine Neuberechnung
                case Richtung.SUED: y1++; break; // der Zielkoordinaten erfolgen
            }
            ZeichenFlaeche rZeichenFlaeche = dieWelt.holeZeichenFlaeche();
            rZeichenFlaeche[xPos, yPos] = "";
            xPos = x1;
            yPos = y1;
            string tierzeichen = "";
            switch (this.dieArt)
            {
                case TierArt.FUCHS: tierzeichen = "F"; break;
                case TierArt.HASE: tierzeichen = "H"; break;
            }
            rZeichenFlaeche[xPos, yPos] = tierzeichen;
        }

        protected void erzeugeNachwuchs()
        {
            dasFutter = 0;
            int newindex = 0;
            while (newindex < 300 && dieWelt.gibTierArt(newindex) != TierArt.NONE)
            {
                newindex++;
            }
            if (newindex < 300)
            {
                int newx, newy;
                do
                {
                    newx = dieWelt.gibZufallszahl(0, 20);
                    newy = dieWelt.gibZufallszahl(0, 15);
                } while (dieWelt.sucheFeldIndex(newx, newy) >= 0);
                TierArt tierart = TierArt.FUCHS;
                if (this.GetType() == typeof(Hase))
                {
                    tierart = TierArt.HASE;
                }
                dieWelt.erzeugeTier(newindex, newx, newy, tierart);
            }
        }
    }
}
