namespace _14._57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("./data.txt");
            var symbols = lines[0].ToCharArray();
            var numSymbols = "";
            var otherSymbols = "";
            foreach(var symbol in symbols)
            {
                if (int.TryParse(symbol.ToString(), out _))
                    numSymbols += symbol;
                else
                    otherSymbols += symbol;
            }
            Console.WriteLine(numSymbols);
            Console.WriteLine(otherSymbols);

            File.WriteAllText("./numData.txt", numSymbols);
            File.WriteAllText("./otherData.txt", otherSymbols);
        }
    }
}