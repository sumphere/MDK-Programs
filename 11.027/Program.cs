using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность осадков длиной в 30 значений, например, 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30");
            var preciptation = new List<double>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (double.TryParse(s, out double num)) preciptation.Add(num);

            if (preciptation.Count != 30)
            {
                Console.WriteLine("надо 30 значений");
                return;
            }

            Console.WriteLine(preciptation.GetRange(0, 10).Average());
            Console.WriteLine(preciptation.GetRange(10, 10).Average());
            Console.WriteLine(preciptation.GetRange(20, 10).Average());
        }
    }
}
