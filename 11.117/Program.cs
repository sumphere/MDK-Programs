using System;
using System.Linq;

namespace _11._117
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var candiesPrices = new int[30].Select((v) => random.Next(70, 340)).ToList();
            var minPrice = candiesPrices.Min();

            var firstIndex = candiesPrices.IndexOf(minPrice);
            var lastIndex = candiesPrices.LastIndexOf(minPrice);
            if (firstIndex == lastIndex)
                Console.WriteLine($"Порядковый номер самого дешевого вида конфет {firstIndex}");
            else
                Console.WriteLine($"Порядковый номер первого из самых дешевых видов конфет: {firstIndex}, последнего из них: {lastIndex}");
        }
    }
}
