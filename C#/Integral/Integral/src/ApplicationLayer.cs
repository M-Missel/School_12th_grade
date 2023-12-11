using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral
{
    internal class ApplicationLayer
    {
        private GUI gui;
        private Funktion styp;
        private int funktionstyp;

        private double xMin, xMax, ParA, ParB, ParC;
        
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
            xMin = gui.gibXMin();
            xMax = gui.gibXMax();
            ParA = gui.gibParA();
            ParB = gui.gibParB();
            ParC = gui.gibParC();

            if (funktionstyp == 0)
                styp = new Gerade();
            if (funktionstyp == 1)
                styp = new Parabel();
            if (funktionstyp == 2)
                styp = new Sinus();

            styp.setzeParameter(ParA, ParB, ParC);
            styp.setzeGrenzen(xMin, xMax);

            gui.zeigeErgebnis(styp.berechneFlaeche(1000));
        }

        public void beendeProgramm()
        {
            Application.Exit();
        }
    }
}
