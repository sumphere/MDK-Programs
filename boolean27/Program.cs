namespace boolean27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Точка с координатами ({x}, {y}) {(x <= 0 ? "" : "не")} лежит во второй или третьей координатной четверти");
        }
    }
}