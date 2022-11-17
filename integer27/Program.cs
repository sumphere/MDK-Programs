namespace integer27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var k = random.Next(1, 366);
            Console.Write($"Номер дня недели = {(k + 5) % 7}; для {k} дня года");
        }
    }
}