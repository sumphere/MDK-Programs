using System;

namespace _1._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Высота точки?");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние до горизона Земли = {height - 6350}");
        }
    }
}
