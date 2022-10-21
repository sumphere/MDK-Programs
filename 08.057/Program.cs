using System;

namespace _8._57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите p");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите q");
            int q = int.Parse(Console.ReadLine());
            for (int i = 2; i <= 1 + 2 * (int)Math.Sqrt(p); i++)
            {
                if (q % i == 0 && p % i == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
