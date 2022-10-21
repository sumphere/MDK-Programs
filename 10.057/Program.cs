using System;

namespace _10._57
{
    class Program
    {
        static bool Simmetric(string str, int i, int j)
        {
            if (j < i) return true;
            if (str[i] != str[j]) return false;
            return Simmetric(str, i + 1, j - 1);
        }
        static void Main(string[] args)
        {
            var str = "abcba";
            Console.WriteLine(Simmetric(str, 0, str.Length - 1));
        }
    }
}
