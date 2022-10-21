using System;

namespace _4._57
{
    class Program
    {
        static void Contains(string num, string n) => Console.WriteLine($"Цифра {n}{(num.Contains(n) ? "" : " не")} входит в число {num}");
        static void Main(string[] args)
        {
            var num = new Random().Next(100, 999).ToString();
            Console.WriteLine($"Выбрано число {num}");

            Contains(num, "6");

            while (true)
            {
                Console.WriteLine("Введите цифру n");
                var n = Console.ReadLine().Substring(0, 1);
                Contains(num, n);
            }
        }
    }
}
