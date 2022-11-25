using System;

namespace proc27
{
    class Program
    {
        static bool IsPowerN(double k, double n)
        {
            if (k < n) return false;
            while (k % n == 0)
                k /= n;
            return k == 1;
        }
        static void Main(string[] args)
        {
            var array = new int[] { 1, -1, 5, 15, 25, 125, 625, 6, 10, 11 };
            var n = 5;
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPowerN(array[i], n)) count++;
            }
            Console.WriteLine(count);
        }
    }
}
