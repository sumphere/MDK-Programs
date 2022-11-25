using System;
using System.Collections.Generic;
using System.Linq;

namespace series37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrays = new List<int[]>();
            Console.WriteLine("Введите наборы целых чисел, разделенных пробелами. " +
                "Оставьте поле пустым для завершения принятия наборов");
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                arrays.Add(input.Split(" ").Select(x => int.Parse(x)).ToArray());
            }

            var kindaSortedArrays = arrays.Where(x =>
            {
                bool asc = true, desc = true;
                for (int i = 1; i < x.Length; i++)
                {
                    if (x[i - 1] > x[i]) asc = false;
                    if (x[i - 1] < x[i]) desc = false;
                    if (!asc && !desc) return false;
                }
                return true;
            });

            Console.WriteLine($"Кол-во: {kindaSortedArrays.Count()}");

            foreach (var arr in kindaSortedArrays)
            {
                foreach (var item in arr)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
}