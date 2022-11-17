using System.Numerics;

namespace project01
{
    class EMath
    {
        public BigInteger Factorial(double value)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= value; i++)
                factorial *= i;

            return factorial;
        }
    }
}
