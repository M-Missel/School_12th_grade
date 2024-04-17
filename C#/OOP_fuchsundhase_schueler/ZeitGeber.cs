using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuchsundhase
{
    class ZeitGeber : System.Windows.Forms.Timer
    {
        private int dasIntervall;
        private Welt dieWelt;

        public ZeitGeber(int intervall, Welt pWelt)
        {
            this.dasIntervall = intervall;
            this.Interval = intervall;
            this.Tick += tickZeitGeber;

            this.dieWelt = pWelt;

            this.Start();
        }

        void tickZeitGeber(object sender, EventArgs e)
        {
            dieWelt.entwickleWelt();
        }
    }
}
