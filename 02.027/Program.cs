using System;

namespace _2._27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Число n?");
                var n = Console.ReadLine();
                if (n.Length != 3)
                {
                    Console.WriteLine("Число n должно быть трехзначным");
                    continue;
                }

                Console.WriteLine($"Число x = {n[2] + n.Remove(2)}");
            }
        }
    }
}
