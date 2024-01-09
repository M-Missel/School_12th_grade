using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class ApplicationLayer
    {
        private GUI gui;
        private GameData gameData;

        private int maxMinen, freeFields;

        public ApplicationLayer(GUI gui) {
            this.gui = gui;
            gameData = new GameData();
            initalisiereSpiel();
        }

        private void initalisiereSpiel()
        {

        }

        public void spieleZug(int xpos, int ypos)
        {

        }

        private int analysiereSpielzug(int xpos, int ypos)
        {

        }
    }
}
