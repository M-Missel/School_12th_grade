using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_racing
{
    internal class Horse
    {
        private int _position;
        private int _number;
        private bool _winner;

        public Horse(int number) {
            _position = 0;
            _number = number;
        }

        public void moveHorse()
        {
            _position += 5;
        }

        public int Position
        {
            get { return _position; }
        }

        public int Number
        {
            get { return _number; }
        }

        public bool Winner
        {
            set => _winner = value;
        }
    }
}
