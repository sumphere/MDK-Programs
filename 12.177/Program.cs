namespace _12._177
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var element = 0;
            var n = 5;
            var matrix = new int[n, n];
            int max = int.MinValue, maxI = 0, maxJ = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ++element;
                    if ((i + j + 1 == n || i == j) && element > max)
                    {
                        max = element;
                        maxI = i;
                        maxJ = j;
                    }
                    Console.Write(matrix[i, j].ToString().PadLeft(3, ' ') + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var mid = n / 2;
            (matrix[maxI, maxJ], matrix[mid, mid]) = (matrix[mid, mid], matrix[maxI, maxJ]);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(3, ' ') + " ");
                Console.WriteLine();
            }
        }
    }
}