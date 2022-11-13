using System;

namespace _11._147
{
    internal class Program
    {
        static void PrintArray<T>(IEnumerable<T> a)
        {
            foreach (var v in a)
            {
                Console.Write(v);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void ReverseRangeBetween<T>(List<T> array, int k, int s)
        {
            int start = k, count = Math.Min(array.Count, s) - (k+1);
            var range = array.GetRange(start, count);
            range.Reverse();
            array.RemoveRange(start, count);
            array.InsertRange(start, range);
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var array = new int[15].Select((v) => random.Next(70, 340)).ToList();
            PrintArray(array);

            var arrayA = array.ToList();
            ReverseRangeBetween(arrayA, 2, 10);
            PrintArray(arrayA);

            var arrayB = array.ToList();
            ReverseRangeBetween(arrayB, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            PrintArray(arrayB);

            var arrayC = array.ToList();
            arrayC.Reverse();
            PrintArray(arrayC);
        }
    }
}

