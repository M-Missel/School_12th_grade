using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Multiple_Inheritance.src
{
    internal class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age) 
        {
            this.subject = subject;
        }

        public string Subject
        {
            get => subject;
        }
    }
}
