namespace _11._237
{
    internal class Program
    {
        static void PrintArray<T>(IEnumerable<T> a)
        {
            foreach (var v in a)
            {
                Console.Write(v);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new int[20].Select((v) => (double)random.Next(0, 100)).ToList();
            PrintArray(list);
            PrintArray(list.Select((v, i) => i == 0 || i % 2 != 0 ? i * v : v / i));
        }
    }
}