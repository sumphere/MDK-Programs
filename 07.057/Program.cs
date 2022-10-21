using System;
using System.Linq;

namespace _7._57
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var speeds = new int[20].Select((v) => random.Next(70, 340));
            var maxSpeed = speeds.Max();

            Console.WriteLine($"Максимальная скорость самого быстрого автомобиля = {maxSpeed}");
        }
    }
}
