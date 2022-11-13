namespace _11._207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new int[20].Select((v) => random.Next(0, 100)).ToList();
            foreach (var v in list)
            {
                Console.Write(v);
                Console.Write(' ');
            }
            Console.WriteLine();
            for (int i = 1; i < list.Count - 1; i++)
            {
                var x = list.ElementAt(i);
                if (x > list.ElementAt(i - 1) && x > list.ElementAt(i + 1))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("Не найдено");
        }
    }
}