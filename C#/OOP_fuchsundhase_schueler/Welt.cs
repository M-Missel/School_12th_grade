using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase
{
    class Welt
    {
        private int alter;
        private Tier[] dasTier;
        private OberFlaeche dieOberFlaeche;
        private ZeitGeber derZeitgeber;

        public Welt(OberFlaeche pOF)
        {
            dieOberFlaeche = pOF;

            int[,] coordsFox = {
                { 1,    1},
                { 18,   3},
                { 10,   10},
                { 12,   5}
            };

            int[,] coordsRabbit = {
                { 1,    2},
                { 2,    5},
                { 1,    12},
                { 3,    7},
                { 8,    12},
                { 12,   12}
            };

            dasTier = new Tier[300];

            for (int i = 0; i < 3; i++)
            {
                dasTier[i] = new Fuchs(coordsFox[0, i], coordsFox[i, 1], this);
            }

            for (int k = 0; k < 5; k++) 
            {
                dasTier[k+4] = new Hase(coordsRabbit[0, k], coordsRabbit[k, 1], this);
            }

            derZeitgeber = new ZeitGeber(100, this);
        }

        public void entwickleWelt()
        {
            bool rLebensBedingung;
            alter++;

            for (int i = 0; i < dasTier.Length; i++)
            {
                if (dasTier[i] != null)
                {
                    rLebensBedingung = dasTier[i].pruefeLebensBedingung();

                    if (rLebensBedingung)
                    {
                        dasTier[i].entwickle();
                    }
                    else
                    {
                        dasTier[i].loescheZeichend();
                        dasTier[i] = null;
                    }
                }
            }

            berechneInfoTiere();
        }

        public int sucheFeldIndex(int pX, int pY)
        {
            int rueckgabe = -1;
            int x = 0, y = 0;

            if (pX < 0 || pX > 19 || pY < 0 || pY > 14)
            {
                rueckgabe = -2;
            }
            else
            {
                for (int i = 0; i < 300; i++)
                {
                    if (dasTier[i] != null)
                    {
                        x = dasTier[i].gibXPos();
                        y = dasTier[i].gibYPos();

                        if (x == pX && y == pY)
                        {
                            rueckgabe = i;
                        }
                    }
                }
            }
                
            return rueckgabe;
        }

        public TierArt gibTierArt(int pIndex)
        {
            return dasTier[pIndex].gibArt();
        }

        public void entferneTier(int pIndex)
        {
            dasTier[pIndex] = null;
        }

        public ZeichenFlaeche holeZeichenFlaeche()
        {
            return dieOberFlaeche.gibZeichenFlaeche();
        }

        public int gibAlter()
        {
            return alter;
        }

        public int gibZufallszahl(int pMin, int pMax)
        {
            Random random = new Random();

            return random.Next(pMin, pMax);
        }

        // die folgenden beiden Methoden sind schon fertig implementiert
        public void berechneInfoTiere()
        {
            int anzFuechse = 0;
            int futFuechse = 0;
            int anzHasen = 0;
            int futHasen = 0;
            for (int i = 0; i < 300; i++)
            {
                if (dasTier[i] != null)
                {
                    TierArt art = dasTier[i].gibArt();
                    int futter = dasTier[i].gibFutter();
                    switch (art)
                    {
                        case TierArt.FUCHS:
                            anzFuechse++;
                            futFuechse += futter;
                            break;
                        case TierArt.HASE:
                            anzHasen++;
                            futHasen += futter;
                            break;
                    }
                }
            }
            dieOberFlaeche.zeigeInfoTiere(anzFuechse, futFuechse, anzHasen, futHasen);
        }

        public void erzeugeTier(int newindex, int newx, int newy, TierArt tierart)
        {
            switch (tierart)
            {
                case TierArt.NONE: break;
                case TierArt.FUCHS:
                    dasTier[newindex] = new Fuchs(newx, newy, this);
                    break;
                case TierArt.HASE:
                    dasTier[newindex] = new Hase(newx, newy, this);
                    break;
            }
        }
    }
}
