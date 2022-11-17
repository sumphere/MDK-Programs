using System;
using System.Collections.Generic;

namespace while27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число Фибоначчи");
            var n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            var fibNumbers = new List<int>() { 1, 1 };
            while (true)
            {
                var preK = fibNumbers.Count - 1;
                var fibNumK = fibNumbers[preK] + fibNumbers[preK - 1];
                fibNumbers.Add(fibNumK);
                if (fibNumK == n)
                {
                    Console.WriteLine($"K = {preK + 1}");
                    break;
                }
                else if (fibNumK > n)
                {
                    Console.WriteLine($"{n} не является числом Фибоначчи");
                    break;
                }
            }
        }
    }
}
