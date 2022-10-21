using System;

namespace _9._27
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "программа";
            Console.WriteLine(word.Substring(1, 2) + word[6]);
            Console.WriteLine(word.Substring(4, 3) + word[0] + word[8]);
        }
    }
}
