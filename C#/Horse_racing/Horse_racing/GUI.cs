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
        Application application = new Application();

        public GUI()
        {
            InitializeComponent();
            application.initHorses();
        }

        public void BTN_Start_Click(object sender, EventArgs e)
        {
            application.startRace();
        }

        public void updateHorse(int pos, int nr)
        {
            // ToDo
        }

        public void BTN_Reset_Click(object sender, EventArgs e)
        {
            // ToDo
        }
    }
}
