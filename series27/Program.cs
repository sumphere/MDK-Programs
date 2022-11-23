namespace series27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор из N вещественных чисел, разделив их пробелами");
            double[] values = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();

            while (true)
            {
                Console.WriteLine("Введите N");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= Math.Min(n, values.Length); i++)
                    Console.Write(Math.Pow(values[i-1], i) + " ");
                Console.WriteLine();
            }
        }
    }
}