using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pacman {
  class Timer: System.Windows.Forms.Timer {
    private int dasIntervall;
    private Steuerung dieSteuerung;

    public Timer(Steuerung pSteuerung, int pIntervall) {
      dieSteuerung=pSteuerung;
      this.dasIntervall=pIntervall;
      this.Interval=pIntervall;
      this.Enabled=false;
      this.Tick+=new System.EventHandler(dieSteuerung.tickTimer);
    }

    public void starte() {
      this.Enabled=true;
    }

    public void stoppe() {
      this.Enabled=false;
    }
  }
}
