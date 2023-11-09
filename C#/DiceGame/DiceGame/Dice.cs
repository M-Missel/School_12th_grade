using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Dice
    {
        private int numberEyes;

        public void roll()
        {
            Random rnd = new Random();
            numberEyes = rnd.Next(1, 7);
        }

        public int NumberEyes
        {
            get => numberEyes;
            set => numberEyes = value;
        }
    }
}
