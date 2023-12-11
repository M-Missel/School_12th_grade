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
        public Gerade() { } 

        protected override double berechneFunktionswert(double x)
        {
            return a * x + b;
        }
    }
}
