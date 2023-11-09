using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class ApplicationLayer
    {
        GUI gui;
        private int rollcounts = 0, totalscore = 0;
        private Dice[] dices = new Dice[3];

        public ApplicationLayer(GUI gui) 
        {
            this.gui = gui;

            for (int i = 0; i < 3; i++)
            {
                dices[i] = new Dice();
            }
        }

        public void play()
        {
            for (int i = 0; i < 3; i++)
            {
                dices[i].roll();
            }

            rollcounts++;
            totalscore += checkScore();

            gui.showRoll(dices[0].NumberEyes, dices[1].NumberEyes, dices[2].NumberEyes);
        }

        private void sortArray()
        {
            int min, temp;
            for (int i = 0; i < dices.Length; i++)
            {
                min = i;
                for (int k = i+1; k < dices.Length; k++)
                {
                    if (dices[k].NumberEyes < dices[i].NumberEyes)
                        min = k;
                }

                temp = dices[min].NumberEyes;
                dices[min].NumberEyes = dices[i].NumberEyes;
                dices[i].NumberEyes = temp;
            }
        }

        private int checkScore()
        {
            sortArray();

            if (dices[0].NumberEyes == 1 && dices[1].NumberEyes == 2 && dices[2].NumberEyes == 3)
                return 4;

            if (dices[0].NumberEyes == 6 && dices[1].NumberEyes == 6 && dices[2].NumberEyes == 6)
                return 6;

            if (dices[0].NumberEyes == 1 && dices[1].NumberEyes == 1 && dices[2].NumberEyes == 1)
                return 2;

            if (dices[0].NumberEyes == dices[1].NumberEyes && dices[1].NumberEyes == dices[2].NumberEyes)
                return 3;

            return 0;
        }
    }
}
