namespace _12._147
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
            var matrix = new int[5, 5];
            var odds = new int?[5];
            var positives = new int[5];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var v = random.Next(-100, 100);
                    matrix[row, col] = v;
                    if (v % 2 != 0 && odds[col] == null)
                        odds[col] = v;
                    if (v >= 0)
                        positives[col] = v;

                    Console.Write(v.ToString().PadLeft(4, ' ') + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Первые нечетные");
            PrintArray(odds);
            Console.WriteLine("Последние позитивные");
            PrintArray(positives);
        }
    }
}