namespace begin27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число A");
                var a = double.Parse(Console.ReadLine());
                a *= a;
                a *= a;
                a *= a;
                Console.WriteLine(a);
            }
        }
    }
}