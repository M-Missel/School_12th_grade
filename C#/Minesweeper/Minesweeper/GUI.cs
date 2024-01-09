using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GUI : Form
    {
        private ApplicationLayer applicationLayer;

        public GUI()
        {
            InitializeComponent();
            applicationLayer = new ApplicationLayer(this);
        }

        public void schreibeAufSpielFeld(int xpos, int ypos, int nachbarMinen)
        {
            SG_GameBoard[xpos, ypos] = Convert.ToString(nachbarMinen);
        }

        public void zeigeVerlorenMeldung()
        {
            L_Status.Text = "Leider Verloren";
        }

        public void zeigeGewonnenMeldung()
        {
            L_Status.Text = "Herzlichen Glückwunsch";
        }

        private void SG_GameBoard_SelectCell(object sender, StringGrid.SelectCellEventArgs e)
        {
            applicationLayer.spieleZug(e.ACol, e.ARow);
        }
    }
}
