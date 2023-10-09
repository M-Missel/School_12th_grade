using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_racing
{
    internal class Application
    {
        private int lenghtTrack = 500;
        private Horse[] horses = new Horse[10];
        GUI gui = new GUI();
        private bool reset = true;

        public void initHorses()
        {
            for (int i = 0; i < horses.Length; i++)
                horses[i] = new Horse(i);
        }

        public void startRace()
        {
            int selectedHorse;

            while (reset)
            {
                selectedHorse = selectHorse();

                if (horses[selectedHorse].Position < lenghtTrack)
                {
                    horses[selectedHorse].moveHorse();
                    gui.updateHorse(selectedHorse, horses[selectedHorse].Number);

                    if (horses[selectedHorse].Position < lenghtTrack - 10)
                        checkWinner(selectedHorse);

                    endRace();
                }
            }
        }

        public void resetRace()
        {
            reset = false;

            for (int i = 0; i < horses.Length; i++)
                horses[i] = null;

            GC.Collect();


        }

        private void endRace()
        {
            int counter = 0;

            for (int i = 0; i < horses.Length; i++)
                counter = (horses[i].Position == 500) ? counter++ : counter;

            reset = (counter == 10) ? false : true;
        }

        private int selectHorse()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }

        private void checkWinner(int index)
        {
            int counter = 0;

            for (int i = 0; i < horses.Length; i++)
                counter = (horses[i].Position == 500) ? counter++ : counter;

            if (counter == 0)
                horses[index].Winner = true;
        }
    }
}
