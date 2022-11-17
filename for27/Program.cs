using System;

namespace for27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите X");
                var x = double.Parse(Console.ReadLine());
                if (Math.Abs(x) >= 1)
                {
                    Console.WriteLine("|X| должно быть меньше 1");
                    continue;
                }
                Console.WriteLine("Введите N");
                var n = int.Parse(Console.ReadLine());

                double result = 0;
                double pow = x;
                double temp1 = 1;
                double temp2 = 1;
                for (int i = 1; i < n - 1; i++)
                {
                    temp1 *= 2 * i - 1;
                    temp2 *= 2 * i;
                    pow *= x * x;
                    result += temp1 * pow / (temp2 * (2 * i + 1));
                }
                Console.WriteLine(result);
            }
        }
    }
}
