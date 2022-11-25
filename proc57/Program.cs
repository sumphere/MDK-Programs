using System;

namespace proc57
{
    class Proc : proc56.Proc
    {
        public static double Perim(double xa, double ya, double xb, double yb, double xc, double yc)
             => Leng(xa, ya, xb, yb) + Leng(xb, yb, xc, yc) + Leng(xc, yc, xa, ya);
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

            Console.WriteLine($"Периметр ABC = {Proc.Perim(a[0], a[1], b[0], b[1], c[0], c[1])}");
            Console.WriteLine($"Периметр ABD = {Proc.Perim(a[0], a[1], b[0], b[1], d[0], d[1])}");
            Console.WriteLine($"Периметр ACD = {Proc.Perim(a[0], a[1], c[0], c[1], d[0], d[1])}");
        }
    }
}
