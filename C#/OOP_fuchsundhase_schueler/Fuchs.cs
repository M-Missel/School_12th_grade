using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase
{

    class Fuchs : Tier
    {
        private int idxHaseZumFressen;
        private int maxHunger;
        private int lastFutter;
        public Fuchs(int pX, int pY, Welt pWelt) : base(pX, pY, pWelt)
        {
            maxHunger = 40;
            ZeichenFlaeche zf = dieWelt.holeZeichenFlaeche();
            zf[pX, pY] = "F";
        }

        // Die folgenden Methoden sind fertig implementiert
        public override bool pruefeLebensBedingung()
        {
            int alter = dieWelt.gibAlter();
            return (alter - this.lastFutter <= maxHunger)
                && (alter - this.gebDat <= maxAlter);
        }

        public override void entwickle()
        {
            Richtung richtung = this.gibZufaelligeRichtung();
            int pruefeRichtung = this.pruefeBewegung(richtung);

            if (pruefeRichtung >= 0)
            {
                if (pruefeRichtung == 2)
                {
                    TierArt tier = dieWelt.gibTierArt(idxHaseZumFressen);
                    if (tier == TierArt.HASE)
                    {
                        dieWelt.entferneTier(idxHaseZumFressen);
                    }

                    lastFutter = dieWelt.gibAlter();
                }

                bewege(richtung);
            }

            if (dasFutter > futterMengeNachwuchs)
            {
                erzeugeNachwuchs();
            }
        }

        private int pruefeBewegung(Richtung pRichtung)
        {
            int xneu = this.xPos;
            int yneu = this.yPos;
            switch (pRichtung)
            {
                case Richtung.OST: xneu++; break;
                case Richtung.NORD: yneu--; break;
                case Richtung.WEST: xneu--; break;
                case Richtung.SUED: yneu++; break;
            }
            int feldBelegung = dieWelt.sucheFeldIndex(xneu, yneu);
            int rueckgabe;
            switch (feldBelegung)
            {
                case -2: rueckgabe = -1; break; // ungültige Koordinaten, 
                                                // d.h. Bewegung nicht möglich
                case -1: rueckgabe = 0; break; // Zielfeld leer: Bewegung möglich
                default:
                    TierArt art = dieWelt.gibTierArt(feldBelegung);
                    if (art == TierArt.HASE)
                    {               // Zielfeld mit Hase belegt:
                        this.idxHaseZumFressen = feldBelegung; // Hase zum Fressen vormerken
                        rueckgabe = 2;
                    }
                    else
                    {                            // Zielfeld mit Fuchs belegt
                        this.idxHaseZumFressen = -1;      // keinen Hasen fressen
                        rueckgabe = -1;                   // keine Bewegung möglich
                    }
                    break;
            }
            return rueckgabe;
        }
    }
}
