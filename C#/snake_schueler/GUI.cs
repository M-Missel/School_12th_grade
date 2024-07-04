using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class GUI : Form
    {
        private Steuerung dieSteuerung;

        public GUI()
        {
            InitializeComponent();
            dieSteuerung = new Steuerung(this);
        }

        private void B_Neu_Click(object sender, EventArgs e)
        {
            dieSteuerung.initGame();
            B_Neu.Visible = false;
            SG_spielplan.Focus();
        }

        private void SG_spielplan_DrawCell(object sender, StringGrid.DrawCellEventArgs e)
        {
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush green = new SolidBrush(Color.Green);
            SolidBrush blue = new SolidBrush(Color.Blue);
            SolidBrush white = new SolidBrush(Color.White);

            for (int i = 0; i < SG_spielplan.RowCount; i++)
            {
                for (int k = 0; k < SG_spielplan.ColCount; k++)
                {
                    if (dieSteuerung.isCoinAt(i, k))
                        e.Graphics.FillRectangle(red, e.CellRect);
                    if (dieSteuerung.isHeadAt(i, k))
                        e.Graphics.FillRectangle(green, e.CellRect);
                    if (dieSteuerung.isTailPart(i, k))
                        e.Graphics.FillRectangle(blue, e.CellRect);
                    else
                        e.Graphics.FillRectangle(white, e.CellRect);
                }
            }
        }

        public void setGameSize(int x, int y)
        {
            SG_spielplan.RowCount = y;
            SG_spielplan.ColCount = x;
            this.Width = SG_spielplan.Width + 2 * SG_spielplan.Left + 20;
            this.Height = SG_spielplan.Height + SG_spielplan.Top + 60;
        }

        public void zeigePunkte(int punkte)
        {
            L_Punkte.Text = punkte.ToString();
        }

        public void zeigeVerloren()
        {
            MessageBox.Show("Verloren");
        }

        private void SG_spielplan_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: dieSteuerung.changeDirectionIfPossible(Direction.left); break;
                //todo: weitere Richtungen
                case Keys.Space: dieSteuerung.pauseGame(); break;
            }
        }
    }
}
