using System;
using System.Collections.Generic;
using System.Linq;

namespace array57
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var n = arr.Length;
            var arr2 = new List<int>();

            for (int i = 0; i < n; i += 2)
                arr2.Add(arr[i]);
            for (int i = 1; i < n; i+=2)
                arr2.Add(arr[i]);

            foreach (var v in arr2)
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
