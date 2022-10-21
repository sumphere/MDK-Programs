using System;

namespace _4._87
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите x");
                var x = double.Parse(Console.ReadLine());
                double fx;
                if (x <= 0) fx = 0;
                else if (x >= 0 && x <= 1) fx = x;
                else fx = Math.Pow(x, 2);
                Console.WriteLine(fx);
            }
        }
    }
}
