using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._57
{
    class Program
    {
        static List<int> GetMarks()
        {
            var marks = new List<int>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (int.TryParse(s, out int num)) marks.Add(num);

            if (marks.Count != 4)
            {
                Console.WriteLine("Последовательность должна быть из 4 оценок");
                throw new Exception("DUmmie");
            }
            return marks;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность из четырех оценок первого ученика");
            var marks1 = GetMarks();

            Console.WriteLine("Введите последовательность из четырех оценок второго ученика");
            var marks2 = GetMarks();

            Console.WriteLine($"Сумма оценок первого - {marks1.Sum()}; второго - {marks2.Sum()}");
        }
    }
}
