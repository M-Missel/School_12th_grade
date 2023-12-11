using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Parabel : Funktion
    {
        public Parabel() { }

        protected override double berechneFunktionswert(double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }
    }
}
