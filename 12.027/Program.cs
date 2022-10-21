using System;
using System.Linq;

namespace _12._27
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 10, n = 10;
            var array2d = new int[m, n];
            var array1d = new int[m * n].Select((_, i) => i).ToArray();

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    array2d[i, k] = array1d[i * m + k];
                    Console.WriteLine(array2d[i, k]);
                }
            }
        }
    }
}
