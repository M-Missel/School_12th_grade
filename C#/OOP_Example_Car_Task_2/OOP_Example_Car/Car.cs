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
        private bool _show;
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

        public bool Show
        {
            get => _show;
        }

        public void do_show()
        {
            _show = true;
        }

        public void dont_show()
        {
            _show = false;
        }
    }
}
