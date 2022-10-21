using System;

namespace _8._27
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 300; n++)
            {
                int c = 0;
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0) c++;
                    if (c > 5) break;
                }
                if (c == 5) Console.WriteLine(n);
            }
        }
    }
}
