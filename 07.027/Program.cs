using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._27
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            Console.WriteLine("Введите числа, разделенные пробелами");
            foreach (var s in Console.ReadLine().Split(' ')) if (int.TryParse(s, out int num) && num > 100) count++;
            Console.WriteLine($"Количество чисел больше, чем 100 = {count}");
        }
    }
}
