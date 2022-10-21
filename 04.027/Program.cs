using System;

namespace _4._27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Число?");
                var n = Console.ReadLine();
                if (n.Length != 3)
                {
                    Console.WriteLine("Число должно быть трехзначным");
                    continue;
                }

                Console.WriteLine($"Число {n}{(n[0] == n[2] ? "" : " не")} является палиндромом");
            }
        }
    }
}
