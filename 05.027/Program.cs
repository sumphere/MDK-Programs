using System;

namespace _5._27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Число a?");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("Число b?");
                var b = int.Parse(Console.ReadLine());

                {
                    int sum = 0;
                    for (int i = 100; i <= 500; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Сумма всех целых чисел от 100 до 500 = {sum}");
                }

                {
                    int sum = 0;
                    for (int i = a; i <= 500; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Сумма всех целых чисел от 100 до 500 = {sum}");
                }
                Console.WriteLine($"х > 1 или y > -2 = {a > 1 || b > -2}");
                Console.WriteLine($"х >= 0 и у < 5 = {a >= 0 && b < 5}");
                Console.WriteLine($"х > 3 или x < -1 = {a > 3 || a < -1}");
                Console.WriteLine($"х > 3 и x < 10 = {a > 3 && a < 10}");
                Console.WriteLine($"неверно, что х > 2 = {a <= 2}");
                Console.WriteLine($"неверно, что х > 0 и х < 5 = {a <= 0 || a >= 5}");
                Console.WriteLine($"10 < x <= 20 = {10 < a && a <= 20}");
                Console.WriteLine($"0 < y <= 4 и x < 5 = {0 < b && b <= 4 && a < 5}");
            }
        }
    }
}
