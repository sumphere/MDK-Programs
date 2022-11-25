using System;
using System.Linq;

namespace proc56
{
    public class Proc
    {
        public static double[] InputCords() => Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
        public static double Leng(double xa, double ya, double xb, double yb)
        => Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A через пробел");
            var a = Proc.InputCords();
            Console.WriteLine("Введите координаты точки B через пробел");
            var b = Proc.InputCords();
            Console.WriteLine("Введите координаты точки C через пробел");
            var c = Proc.InputCords();
            Console.WriteLine("Введите координаты точки D через пробел");
            var d = Proc.InputCords();

            Console.WriteLine($"|AB| = {Proc.Leng(a[0], a[1], b[0], b[1])}");
            Console.WriteLine($"|AC| = {Proc.Leng(a[0], a[1], c[0], c[1])}");
            Console.WriteLine($"|AD| = {Proc.Leng(a[0], a[1], d[0], d[1])}");
        }
    }
}
