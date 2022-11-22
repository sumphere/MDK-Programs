using System.Text.RegularExpressions;

namespace _14._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("./data.txt");
            Console.WriteLine(lines[0]);

            Regex regex = new(@"\d+");
            
            Console.WriteLine($"a) {regex.Replace(lines[0], v => int.Parse(v.Value) % 2 == 0 ? "0" : v.Value, 13)}");
            Console.WriteLine($"б) {regex.Replace(lines[0], v => int.Parse(v.Value) % 2 == 0 ? "0" : v.Value)}");
        }
    }
}