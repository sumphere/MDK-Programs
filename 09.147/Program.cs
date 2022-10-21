using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _9._147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст вида \"d1+-d2+-d3...\"");
            var str = Console.ReadLine();

            var regex = new Regex(@"[+-]?(\d+(,\d+)?)");
            var list = new List<double>();
            foreach (var a in regex.Matches(str).AsEnumerable())
            {
                list.Add(double.Parse(a.Groups[1].Value) * (a.Value.StartsWith("-") ? -1 : 1));
            }

            Console.WriteLine(list.Sum());
        }
    }
}
