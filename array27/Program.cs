using System;
using System.Linq;

namespace array27
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var n = arr.Length;
            foreach (var v in arr)
                Console.Write(v + " ");
            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {
                if (Math.Sign(arr[i - 1]) == Math.Sign(arr[i]))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
        }
    }
}
