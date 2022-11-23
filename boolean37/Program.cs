namespace boolean37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите координаты первого поля x1 y1(в диапазоне 1-8), разделив их пробелами");
                int[] field1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                Console.WriteLine("Введите координаты второго поля x2 y2(в диапазоне 1-8), разделив их пробелами");
                int[] field2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();


                bool cond = field1[0] - field2[0] == field1[1] - field2[1] ||
                            field1[0] == field2[0] || field1[1] == field2[1];
                Console.WriteLine($"Король за один ход {(cond ? "" : "не ")}может перейти с одного поля на другое");
            }
        }
    }
}