namespace _12._057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var total = 0;
            var payments = new int[12, 18];
            for (int i = 0; i < payments.GetLength(0); i++)
            {
                for (int j = 0; j < payments.GetLength(1); j++)
                {
                    payments[i, j] = random.Next(20_000, 30_000);
                    total += payments[i, j];
                }
            }
            Console.WriteLine(total);
        }
    }
}