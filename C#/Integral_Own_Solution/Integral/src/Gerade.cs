using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Gerade : Funktion
    {
        public Gerade(double a, double b, double xMin, double xMax) {
            this.a = a;
            this.b = b;
            this.xMin = xMin;
            this.xMax = xMax;
        } 

        protected override double berechneFunktionswert(double x)
        {
            return a * x + b;
        }
    }
}
