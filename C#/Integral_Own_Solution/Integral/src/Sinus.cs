using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Sinus : Funktion
    {
        public Sinus(double a, double b, double c, double xMin, double xMax)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.xMin = xMin;
            this.xMax = xMax;
        }

        protected override double berechneFunktionswert(double x)
        {
            return a * Math.Sin(b * x + c);
        }
    }
}
