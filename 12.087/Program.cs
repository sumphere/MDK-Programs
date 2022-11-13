namespace _12._087
{
    internal class Program
    {
        enum ColOrRow
        {
            Col,
            Row,
        }
        enum MinOrMax
        {
            Min,
            Max,
        }
        static int Find(int[,] matrix, ColOrRow colOrRow, MinOrMax minOrMax)
        {
            int index = 0;
            int toCompare = minOrMax == MinOrMax.Min ? int.MaxValue : int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minOrMax == MinOrMax.Min ? matrix[i, j] <= toCompare : matrix[i, j] >= toCompare)
                    {
                        toCompare = matrix[i, j];
                        index = colOrRow == ColOrRow.Row ? i : j;
                    }
                }
            }
            return index;
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

            Console.WriteLine(Find(matrix, ColOrRow.Row, MinOrMax.Max));
            Console.WriteLine(Find(matrix, ColOrRow.Col, MinOrMax.Min));
        }
    }
}