using System;
using System.Collections.Generic;

namespace _9._177
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            var amogus = new Dictionary<string, int>();
            string word = "";
            foreach (var s in Console.ReadLine().Split(' '))
            {
                if (amogus.ContainsKey(s))
                {
                    word = s;
                    break;
                }
                else amogus.Add(s, 1);
            }
            Console.WriteLine(word);
        }
    }
}
