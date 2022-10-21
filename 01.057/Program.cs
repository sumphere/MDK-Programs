using System;

namespace _1._57
{
    class Program
    {
        static void Main(string[] args)
        {
            var tC = 36.6;
            var tF = tC * 1.8 + 32;
            var tK = 273.15 + tC;
            Console.WriteLine($"По Цельсию = {tC}, по Фаренгейту = {tF}, по Кельвину = {tK}");
        }
    }
}
