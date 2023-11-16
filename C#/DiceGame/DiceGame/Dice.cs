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
        private Random rnd = new Random();
        
        public void roll()
        {
            numberEyes = rnd.Next(1, 7);
            Console.WriteLine(numberEyes);
        }

        public int NumberEyes
        {
            get => numberEyes;
            set => numberEyes = value;
        }
    }
}
