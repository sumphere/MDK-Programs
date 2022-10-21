using System;

namespace _4._117
{
    class Program
    {
        // 30 - 29
        // 30 - 30
        // 29 - 30
        // 29 - 32
        static (int c1, int c2) Solve(int a1, int a2, int b1, int b2)
        {
            if (b1 <= a1)
                return (a1 - b1 - (a2 < b2 ? 1 : 0), (a2 < b2 ? 10 : 0) + a2 - b2);
            else
                return (b1 - a1 - (b2 < a2 ? 1 : 0), (b2 < a2 ? 10 : 0) - a2 + b2);
        }
        static void Main(string[] args)
        {
            var (c1, c2) = Solve(2, 7, 4, 8);
            Console.WriteLine($"{c1} {c2}");
        }
    }
}
