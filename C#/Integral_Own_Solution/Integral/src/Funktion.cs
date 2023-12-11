using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    abstract class Funktion
    {
        protected double a, b, c, xMin, xMax;

        protected abstract double berechneFunktionswert(double x);

        public double berechneFlaeche(int n)
        {
            double returnValue = 0, xValue = xMin;
            double deltaX = (Math.Abs(xMin) + Math.Abs(xMax)) / n;

            for(int i = 0; i < n; i++)
            {
                returnValue += Math.Abs(berechneFunktionswert(xValue) * deltaX);
                xValue += deltaX;
            }

            return returnValue;
        }
    }
}
