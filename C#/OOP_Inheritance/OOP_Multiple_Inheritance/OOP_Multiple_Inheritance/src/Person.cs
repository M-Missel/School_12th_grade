using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Multiple_Inheritance.src
{
    internal class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age) { 
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get => name;
        }

        public int Age
        {
            get => age;
        }
    }
}
