namespace _15._27
{
    internal class Program
    {
        static void Main(string[] args) =>
            File.WriteAllLines("./data2.txt", File.ReadAllLines("./data.txt").Where(l => l.Length > 30));
    }
}