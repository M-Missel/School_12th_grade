using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    internal class Person
    {
        private string _name;
        private Int64 _tel;

        public Person(string name, Int64 tel)
        {
            _name = name;
            _tel = tel;
        }

        public string Name
        {
            get => _name;
        }

        public Int64 Tel
        {
            get => _tel;
        }
    }
}
