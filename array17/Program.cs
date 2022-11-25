using System;
using System.Linq;

namespace array17
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var n = arr.Length;
            for (int i = 0; i < n / 2 + 1; i += 2)
            {
                if (i <= n / 2) Console.Write(arr[i] + " ");
                if (i <= n / 2 - 1) Console.Write(arr[i + 1] + " ");
                if (n - 1 - i > n / 2) Console.Write(arr[n - 2 - i + 1] + " ");
                if (n - 1 - i > n / 2) Console.Write(arr[n - 2 - i] + " ");
            }
        }
    }
}
