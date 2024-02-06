using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pacman
{
    public partial class OberFlaeche : Form
    {
        private Steuerung dieSteuerung;
        private ZeichenFlaeche zeichenflaeche;
        public OberFlaeche()
        {
            zeichenflaeche = new ZeichenFlaeche(this);
            this.Controls.Add(this.zeichenflaeche);
            InitializeComponent();
            this.Focus();
            dieSteuerung = new Steuerung(this);
        }

        public ZeichenFlaeche gibZeichenFlaeche()
        {
            return this.zeichenflaeche;
        }

        public void ereignisTastatur(object sender, KeyEventArgs e)
        {
            int richtung;
            switch (e.KeyCode)
            {
                case Keys.Up: richtung = 2; break;
                case Keys.Down: richtung = 4; break;
                case Keys.Left: richtung = 3; break;
                case Keys.Right: richtung = 1; break;
                default: richtung = 0; break;
            }
            dieSteuerung.verarbeiteTastenDruck(richtung);
        }

        private void clickStart(object sender, MouseEventArgs e)
        {
            dieSteuerung.starteSpiel();
        }

        public void schreibePunkte(int pPunkte)
        {
            L_Punkte.Text = pPunkte.ToString();
        }

        public void zeigeMeldung(string pText)
        {
            MessageBox.Show(pText);
        }
    }
}