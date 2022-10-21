using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            var amogus = new List<double>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (double.TryParse(s, out double num)) amogus.Add(num);

            Console.WriteLine("Введите число p");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма чисел bi ({amogus.Sum()}) {(amogus.Sum() < p ? "меньше" : "не меньше")} чем число p ({p})");
        }
    }
}
