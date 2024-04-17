using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase
{
    class Hase : Tier
    {
        public Hase(int pX, int pY, Welt pWelt) : base(pX, pY, pWelt)
        {
            ZeichenFlaeche zf = dieWelt.holeZeichenFlaeche();
            zf[pX, pY] = "H";
        }

        // die folgenden 3 Methoden sind fertig implementiert
        public override void entwickle()
        {
            Richtung richtung = this.gibZufaelligeRichtung();
            int pruefErgebnis = this.pruefeBewegung(richtung);
            if (pruefErgebnis == 0)
            {
                this.bewege(richtung);
                this.dasFutter++;
                if (dasFutter > futterMengeNachwuchs)
                {
                    this.erzeugeNachwuchs();
                }
            }
        }

        public override bool pruefeLebensBedingung()
        {
            return (dieWelt.gibAlter() - gebDat <= maxAlter);
        }

        private int pruefeBewegung(Richtung pRichtung)
        {
            int x1 = this.xPos;
            int y1 = this.yPos;
            int rueckgabe;
            switch (pRichtung)
            {
                case Richtung.OST: x1++; break;
                case Richtung.NORD: y1--; break;
                case Richtung.WEST: x1--; break;
                case Richtung.SUED: y1++; break;
            }
            int feldBelegung = dieWelt.sucheFeldIndex(x1, y1);
            switch (feldBelegung)
            {
                case -2: rueckgabe = -1; break; // ungültige Koordinaten, d.h.
                                                // Bewegung nicht möglich
                case -1: rueckgabe = 0; break; // Zielfeld leer, d.h. Bewegung möglich
                default: rueckgabe = -1; break; // Hase kann nur auf ein leeres gehen
            }
            return rueckgabe;
        }
    }
}
