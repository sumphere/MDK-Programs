using System;
using System.Linq;

namespace minmax27
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var n = 100;
            var arr = new int[n].Select(_ => rand.Next(2)).ToArray();

            int maxIndex = 0, maxCount = 0;
            int seqIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i - seqIndex > maxCount)
                {
                    maxCount = i - seqIndex;
                    maxIndex = seqIndex;
                }

                if (arr[i] != arr[i - 1])
                    seqIndex = i;
            }

            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine(maxIndex + " " + maxCount);
        }
    }
}
