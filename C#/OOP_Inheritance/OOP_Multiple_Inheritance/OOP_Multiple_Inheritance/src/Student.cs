using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Multiple_Inheritance.src
{
    internal class Student : Person
    {
        private string stdClass;

        public Student(string name, int age, string stdClass) : base (name,age)
        {
            this. stdClass = stdClass;
        }

        public string Class
        {
            get => stdClass;
        }
    }
}
