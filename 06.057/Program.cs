using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            var amogus = new List<double>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (double.TryParse(s, out double num)) amogus.Add(num);

            Console.WriteLine("Введите число n");
            double n = double.Parse(Console.ReadLine());

            double closestDist = double.MaxValue;
            int closestIndex = 0;
            for (int i = 0; i < amogus.Count; i++)
            {
                double dist = Math.Abs(n - amogus[i]);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    closestIndex = i;
                }
            }

            Console.WriteLine($"Значение ближайшего элемента {amogus[closestIndex]}; его индекс {closestIndex}");
            Console.Read();
        }
    }
}
