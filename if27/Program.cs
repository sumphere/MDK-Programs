using System;

namespace if27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите x");
                var x = double.Parse(Console.ReadLine());
                int f = 0;

                if (x < 0) f = 0;
                else if (x % 2 < 1)
                    f = 1;
                else if (x % 2 >= 1)
                    f = -1;
                Console.WriteLine(f);
            }
        }
    }
}
