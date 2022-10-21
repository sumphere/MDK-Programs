using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._87
{
    enum Gender
    {
        Male,
        Female,
    }
    class Student
    {
        public Gender Gender;
        public int Height;
        public static Student Random()
        {
            var random = new Random();
            var genderRoll = random.Next(1, 3);
            return new Student()
            {
                Gender = genderRoll == 1 ? Gender.Female : Gender.Male,
                Height = random.Next(70, 200) * (genderRoll == 1 ? 1 : -1),
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new int[22].Select((v) => Student.Random());
            var averageBoyHeight = studentList.Where(v => v.Gender == Gender.Male).Select(v => v.Height).Average() * -1;
            var averageGirlHeight = studentList.Where(v => v.Gender == Gender.Female).Select(v => v.Height).Average();

            Console.WriteLine($"Средний рост мальчиков = {averageBoyHeight}");
            Console.WriteLine($"Средний рост девочек = {averageGirlHeight}");
        }
    }
}
