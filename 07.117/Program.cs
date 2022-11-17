using System;
using System.Collections.Generic;

namespace _7._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            var amogus = new List<int>();
            foreach (var s in Console.ReadLine().Split(' '))
                if (int.TryParse(s, out int num)) amogus.Add(num);
            var lastIndex = amogus.LastIndexOf(100);

            Console.WriteLine(lastIndex != -1 ? $"Номер последнего числа, равного 100 = {lastIndex + 1}" : "Числа 100 нет в этой последовательности");
        }
    }
}
