using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project01
{
    class EMath
    {
        public double VariableDegree(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public BigInteger Factorial(double value)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= value; i++)
                factorial *= i;

            return factorial;
        }

        public double Rnd()
        {
            Random rnd = new Random();
            double d = Math.Round(0.1 + rnd.NextDouble() * 0.89, 13);

            return d;
        }
    }
}
