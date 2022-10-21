using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность осадков в феврале");
            var preciptation = new List<double>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (double.TryParse(s, out double num)) preciptation.Add(num);

            Console.WriteLine(preciptation.Where((d, i) => (i + 1) % 2 == 0).Sum());
        }
    }
}
