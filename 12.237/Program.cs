namespace _12._237
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix, int pad = 3)
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
                    matrix[i, j] = random.Next(100);

            while (true)
            {
                Console.WriteLine("Матрица");
                PrintMatrix(matrix);
                Console.WriteLine("Выбирите, что хотите удалить: 1 - строки, 2 - столбцы");
                var choice = Console.ReadLine();
                Console.WriteLine("Введите первую границу сегмента для удаления, на следующей строке вторую");
                var s1 = int.Parse(Console.ReadLine());
                var s2 = int.Parse(Console.ReadLine());

                var result = choice == "1"
                    ? new int[matrix.GetLength(0) - (s2 - s1) - 1, matrix.GetLength(1)]
                    : new int[matrix.GetLength(0), matrix.GetLength(1) - (s2 - s1) - 1];

                for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
                {
                    if (choice == "1" && i >= s1 && i <= s2)
                        continue;

                    for (int k = 0, u = 0; k < matrix.GetLength(1); k++)
                    {
                        if (choice != "1" && k >= s1 && k <= s2)
                            continue;

                        result[j, u] = matrix[i, k];
                        u++;
                    }
                    j++;
                }

                PrintMatrix(result);
            }
        }
    }
}