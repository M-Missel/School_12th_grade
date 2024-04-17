using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuchsundhase
{
    public partial class OberFlaeche : Form
    {
        private Welt dieWelt;
        private ZeichenFlaeche dieZeichenFlaeche;
        public OberFlaeche()
        {
            InitializeComponent();
            dieZeichenFlaeche = new ZeichenFlaeche();
            this.Controls.Add(this.dieZeichenFlaeche);
            dieWelt = new Welt(this);
        }

        public ZeichenFlaeche gibZeichenFlaeche()
        {
            return dieZeichenFlaeche;
        }

        // die folgende Methode ist schon fertig implementiert
        public void zeigeInfoTiere(int pAnzFuechse, int pFutFuechse,
                                   int pAnzHasen, int pFutHasen)
        {
            L_AnzF.Text = pAnzFuechse.ToString();
            L_FutF.Text = pFutFuechse.ToString();
            L_AnzH.Text = pAnzHasen.ToString();
            L_FutH.Text = pFutHasen.ToString();
        }
    }
}
