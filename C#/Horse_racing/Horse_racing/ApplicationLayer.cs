using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_racing
{
    internal class ApplicationLayer
    {
        private ApplicationLayer applicationLayer;
        private GUI gui;
        private Random random = new Random();
        private Timer timer;

        private int lenghtTrack;
        private Horse[] horses = new Horse[10];
        
        public ApplicationLayer(GUI gui)
        {
            this.gui = gui;
            lenghtTrack = 500;

            for (int i = 0; i < horses.Length; i++)
            {
                horses[i] = new Horse(i);
            }

            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 100;
            timer.Tick += new EventHandler(nextstep);
        }

        public void startRace()
        {
            timer.Enabled= true;

            // timer.Start();
        }

        private int selectHorse()
        {
            return random.Next(0, 10);
        }

        private bool endRace()
        {
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].getPos() < lenghtTrack)
                    return false;
            }

            return true;
        }

        public void nextstep(object sender, EventArgs e)
        {
            int nr, pos;

            while (endRace() == false)
            {
                nr = selectHorse();
                horses[nr].move();
                pos = horses[nr].getPos();
                gui.updateHorse(pos, nr);
            }
        }
    }
}
