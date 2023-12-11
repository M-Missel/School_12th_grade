using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Sinus : Funktion
    {
        public Sinus() { }

        protected override double berechneFunktionswert(double x)
        {
            return a * Math.Sin(b * x + c);
        }
    }
}
