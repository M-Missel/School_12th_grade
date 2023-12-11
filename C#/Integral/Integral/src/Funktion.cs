using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    abstract class Funktion
    {
        protected double a;
        protected double b;
        protected double c;
        protected double xMin;
        protected double xMax;

        protected abstract double berechneFunktionswert(double x);

        public double berechneFlaeche(int n)
        {
            double returnValue = 0;
            double xValue = xMin;
            double deltaX = (Math.Abs(xMin) + Math.Abs(xMax)) / n;

            for(int i = 0; i < n; i++)
            {
                returnValue += Math.Abs(berechneFunktionswert(xValue) * deltaX);
                xValue += deltaX;
            }

            return returnValue;
        }

        public void setzeParameter(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void setzeGrenzen(double min, double max)
        {
            this.xMin = min;
            this.xMax = max;
        }
    }
}
