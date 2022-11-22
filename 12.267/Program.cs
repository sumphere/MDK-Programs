namespace _12._267
{
    internal class Program
    {
        static void PrintArray<T>(IEnumerable<T> a)
        {
            foreach (var v in a)
                Console.Write(v + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                    Console.Write(matrix[i, j].ToString().PadLeft(4, ' ') + " ");
                }
                Console.WriteLine();
            }

            var tempA = new int[matrix.GetLength(1)];
            var tempB = new int[matrix.GetLength(0)];
            var tempC = new int[matrix.GetLength(0)];
            var tempD = new int[matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var v = matrix[i, j];
                    if (v % 2 == 0 && v > 0)
                        tempA[j] += v;
                    if (v % 2 != 0 && v < 0)
                        tempB[i]++;
                    if ((v % 3 == 0 || v % 7 == 0) && v < 0)
                        tempC[i]++;
                    if ((v % 4 == 0 || v % 5 == 0) && v > 0)
                        tempD[j] += v;
                }

            Console.Write("а) ");
            PrintArray(tempA);
            Console.Write("б) ");
            PrintArray(tempB);
            Console.Write("в) ");
            PrintArray(tempC);
            Console.Write("г) ");
            PrintArray(tempD);
        }
    }
}