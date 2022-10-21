using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._27
{
    class Program
    {
        static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа, когда амогус то не число");
            var numbers = new List<int>();
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int n)) numbers.Add(n);
                else break;
            }

            var result = numbers.ElementAtOrDefault(0);
            for (int i = 1; i < numbers.Count; i++)
            {
                result = GCD(result, numbers[i]);
            }
            Console.WriteLine($"Наибольший общий делитель всех этих чисел это {result}");
        }
    }
}
