using System;
using System.Linq;

namespace array87
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var n = 10;
            var arr = new int[n - 1].Select(_ => rand.Next(100)).ToList();
            arr.Sort();
            arr = arr.Prepend(rand.Next(100)).ToList();
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            arr.Sort();
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
