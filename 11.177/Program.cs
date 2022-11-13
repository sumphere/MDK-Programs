namespace _11._177
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
            var carList = new int[20].Select((v) => random.Next(150)).ToList();
            carList.Sort();

            Console.WriteLine("О нет, срочно введите число от 1 до 30");
            var k = Math.Clamp(int.Parse(Console.ReadLine()), 1, 30);
            var item = carList.ElementAt(k - 1);
            carList.RemoveAt(k - 1);
            carList.Insert(random.Next(0, 30), item);
            PrintArray(carList);

            Console.WriteLine("Сортируем...");
            carList.Sort();
            PrintArray(carList);
        }
    }
}