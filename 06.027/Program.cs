using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                var n = Console.ReadLine().Aggregate(new List<int>(), (l, c) =>
                {
                    if (int.TryParse(c.ToString(), out int res)) l.Add(res);
                    return l;
                });

                int min = n.Min(), max = n.Max();
                Console.WriteLine($"Минимальное число - {min}, максимальное - {max}");
                Console.WriteLine($"Разница - {max - min}");
                Console.WriteLine($"Сумма - {min + max}");
            }
        }
    }
}
