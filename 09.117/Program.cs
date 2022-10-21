using System;

namespace _9._117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();

            var removedCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(str[i].ToString()))
                {
                    str = str.Remove(i, 1);
                    str += "_";
                    removedCount++;
                }
            }

            var isMirrored = true;
            for (int i = 0; i < str.Length - removedCount; i++)
            {
                if (str[i] != str[str.Length - removedCount - i - 1])
                {
                    isMirrored = false;
                    break;
                }
            }

            Console.WriteLine(isMirrored);
        }
    }
}
