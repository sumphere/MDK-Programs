namespace for37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите N");
                var n = double.Parse(Console.ReadLine());
                if (Math.Abs(n) <= 0)
                {
                    Console.WriteLine("N должно быть больше 0");
                    continue;
                }

                ulong result = 0;
                for (int i = 1; i <= n; i++)
                    result += (ulong)Math.Pow(i, i);
                Console.WriteLine(result);
            }
        }
    }
}