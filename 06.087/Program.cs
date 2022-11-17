using System;

namespace _6._87
{
    class Program
    {
        static void Main(string[] args)
        {
            int team1 = 0, team2 = 0;
            while (true)
            {
                Console.WriteLine("Выберите количество очков, полученных в этом раунде, от 0 до 3 (0 для окончания матча)");
                int score = Math.Max(0, Math.Min(3, int.Parse(Console.ReadLine())));
                if (score == 0) break;

                Console.WriteLine($"Выберите команду, которая получит {score} очков (1 или 2)");
                if (Console.ReadLine() == "1") team1 += score;
                else team2 += score;

                Console.WriteLine($"Счет: Первая команда - {team1}, Вторая команда - {team2}");
            }
            Console.WriteLine($"Матч закончился со счетом {team1} - {team2}");
            Console.Read();
        }
    }
}
