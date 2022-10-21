using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._27
{
    class Program
    {
        static Dictionary<string, int> RandomCar()
        {
            var random = new Random();
            var car = new Dictionary<string, int>();
            car.Add("Price", random.Next(10, 500) * 10000);
            car.Add("Age", random.Next(1, 20));
            return car;
        }
        static void Main(string[] args)
        {
            var carList = new int[20].Select((v) => RandomCar());
            var averagePrice = carList.Where(v => v["Age"] > 6).Select(v => v["Price"]).Average();
            
            Console.WriteLine($"Средняя стоимость автомобилей старше 6 лет = {averagePrice}");
        }
    }
}
