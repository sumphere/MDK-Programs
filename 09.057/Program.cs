using System;

namespace _9._57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'и' || str[i] == 'И') && i % 2 == 0)
                {
                    Console.WriteLine($"{str[i]} - {i}");
                }
            }
        }
    }
}
