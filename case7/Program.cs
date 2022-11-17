using System;

namespace case7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите единицу массы");
                var massType = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите массу");
                var mass = double.Parse(Console.ReadLine());

                double mul = 1;
                var badMassType = false;
                switch (massType)
                {
                    default:
                        badMassType = true;
                        break;
                    case 1:
                        break;
                    case 2:
                        mul = 1e-6;
                        break;
                    case 3:
                        mul = 0.001;
                        break;
                    case 4:
                        mul = 1000;
                        break;
                    case 5:
                        mul = 100;
                        break;
                }

                if (!badMassType) Console.WriteLine(mass * mul);
                else Console.WriteLine("Неверный тип массы");
            }
        }
    }
}
