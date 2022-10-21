using System;

namespace _3._27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Число x?");
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine("Число y?");
                var y = double.Parse(Console.ReadLine());

                Console.WriteLine($"х > 2 и у > 3 = {x > 2 && y > 3}");
                Console.WriteLine($"х > 1 или y > -2 = {x > 1 || y > -2}");
                Console.WriteLine($"х >= 0 и у < 5 = {x >= 0 && y < 5}");
                Console.WriteLine($"х > 3 или x < -1 = {x > 3 || x < -1}");
                Console.WriteLine($"х > 3 и x < 10 = {x > 3 && x < 10}");
                Console.WriteLine($"неверно, что х > 2 = {x <= 2}");
                Console.WriteLine($"неверно, что х > 0 и х < 5 = {x <= 0 || x >= 5}");
                Console.WriteLine($"10 < x <= 20 = {10 < x && x <= 20}");
                Console.WriteLine($"0 < y <= 4 и x < 5 = {0 < y && y <= 4 && x < 5}");
            }
        }
    }
}
