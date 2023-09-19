using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Car
{
    class Car
    {
        private string _color;
        private int _price;
        /*
        public Car()
        {

        }

        ~Car()
        {

        }
        */
        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }
    }
}
