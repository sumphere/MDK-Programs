using System;

namespace _5._87
{
    class Program
    {
        static int Sqr(int n)
        {
            var res = 0;
            for (int i = 1; i <= n; i++) res += 2 * i - 1;
            return res;
        }
        static void Main(string[] args)
        {
            var res = 0;
            for (int i = 1; i <= 10; i++) res += Sqr(i);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
