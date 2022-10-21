using System;
using System.Text.RegularExpressions;

namespace _9._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            var str = Console.ReadLine();

            var regex = new Regex(@"([чщ])я");
            Console.WriteLine(regex.Replace(str, "$1а"));
        }
    }
}
