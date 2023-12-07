using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_racing
{
    public partial class GUI : Form
    {
        private ApplicationLayer applicationLayer;
        private Graphics graphics;

        public GUI()
        {
            InitializeComponent();
            graphics = PB_Track.CreateGraphics();
            applicationLayer = new ApplicationLayer(this);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            applicationLayer.startRace();
        }

        public void updateHorse(int pos, int nr)
        {
            int size = 25, space = 5;
            graphics.DrawRectangle(Pens.White, pos -1, nr*(size+space)-1, space+2, size+2);
            graphics.FillRectangle(Brushes.Blue, pos, nr*(size+space), size, size);
        }
    }
}
