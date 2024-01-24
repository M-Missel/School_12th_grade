using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral
{
    public enum Funktionstyp
    {
        gerade,
        parabel,
        sinus
    }

    internal class ApplicationLayer
    {
        private GUI gui;
        private Funktion styp;
        private int funktionstyp;

        public ApplicationLayer(GUI gui) {
            this.gui = gui;
        }

        public void tastaturEreignis()
        {
            funktionstyp = (int)gui.gibFunkstyp();

            ermittleFlaeche();
        }

        private  void ermittleFlaeche()
        {
            if (funktionstyp == 0)
                styp = new Gerade(gui.gibParA(), gui.gibParB(), gui.gibXMin(), gui.gibXMax());
            if (funktionstyp == 1)
                styp = new Parabel(gui.gibParA(), gui.gibParB(), gui.gibParC(),gui.gibXMin(), gui.gibXMax());
            if (funktionstyp == 2)
                styp = new Sinus(gui.gibParA(), gui.gibParB(), gui.gibParC(),gui.gibXMin(), gui.gibXMax());

            gui.zeigeErgebnis(styp.berechneFlaeche(gui.gibAnz()));

            styp = null;
        }

        public void beendeProgramm()
        {
            Application.Exit();
        }
    }
}
