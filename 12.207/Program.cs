namespace _12._207
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix, int pad = 4)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(pad, ' ') + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(-100, 100);
            PrintMatrix(matrix);

            var tempA = (int[,])matrix.Clone();
            var tempB = (int[,])matrix.Clone();
            var tempC = (int[,])matrix.Clone();
            var tempD = (int[,])matrix.Clone();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (tempA[i, j] % 2 != 0)
                        tempA[i, j] -= tempA[i, tempA.GetLength(1) - 1];
                    if (tempB[i, j] < 0)
                        tempB[i, j] *= tempB[0, j];
                    if (tempC[i, j] % 2 == 0)
                        tempC[i, j] += tempC[tempC.GetLength(0) - 1, j];
                    else
                        tempC[i, j] += tempC[i, 1];
                    if ((i + j) % 2 == 0)
                        tempD[i, j] = -1;
                }
            }
            Console.WriteLine("а)");
            PrintMatrix(tempA);
            Console.WriteLine("б)");
            PrintMatrix(tempB, 8);
            Console.WriteLine("в)");
            PrintMatrix(tempC);
            Console.WriteLine("г)");
            PrintMatrix(tempD);
        }
    }
}