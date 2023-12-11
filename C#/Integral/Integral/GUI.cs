using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral
{
    public partial class GUI : Form
    {
        private ApplicationLayer applicationLayer;

        public enum Funktionstyp
        {
            gerade,
            parabel, 
            sinus
        }

        public GUI()
        {
            InitializeComponent();
            applicationLayer = new ApplicationLayer(this);
        }

        public void zeigeErgebnis(double flaeche)
        {
            TB_Flaeche.Text = Convert.ToString(flaeche);
        }

        public Funktionstyp gibFunkstyp()
        {
            var value = Funktionstyp.gerade;

            if (RB_Gerade.Checked)
                value = Funktionstyp.gerade;
            if(RB_Parabel.Checked)
                value = Funktionstyp.parabel;
            if(RB_Sinus.Checked)
                value = Funktionstyp.sinus;

            return value;
        }

        public double gibXMin()
        {
            return Convert.ToDouble(TB_XMin.Text);
        }

        public double gibXMax()
        {
            return Convert.ToDouble(TB_xMax.Text);
        }

        public double gibParA()
        {
            return Convert.ToDouble(TB_A.Text);
        }

        public double gibParB()
        {
            return Convert.ToDouble(TB_B.Text);
        }

        public double gibParC()
        {
            return Convert.ToDouble(TB_C.Text);
        }

        public void clickBerechne(object sender, EventArgs e)
        {
            applicationLayer.tastaturEreignis();
        }

        public void clickBeende(object sender, EventArgs e)
        {
            applicationLayer.beendeProgramm();
        }
    }
}
