namespace _12._117
{
    internal class Program
    {
        static T[] GetRow<T>(T[,] matrix, int row)
        {
            var rowLength = matrix.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }
        static T[] GetCol<T>(T[,] matrix, int col)
        {
            var colLength = matrix.GetLength(0);
            var colVector = new T[colLength];

            for (var i = 0; i < colLength; i++)
                colVector[i] = matrix[i, col];

            return colVector;
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100);
                    Console.Write(matrix[i, j].ToString().PadLeft(3, ' ') + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(GetRow(matrix, 0).Sum() % 2 == 0);
            Console.WriteLine("Введите номер стобца, начиная с нуля");
            var colNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetCol(matrix, colNum).Sum() % num == 0);
        }
    }
}