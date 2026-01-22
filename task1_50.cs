using System;
using System.Globalization;

class Program
{
    static double ReadDouble()
    {
        var s = Console.ReadLine()!.Trim().Replace(',', '.');
        return double.Parse(s, CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        // Ввод: a b alpha
        // a - меньшее основание, b - большее основание, alpha - угол при большем основании (в радианах)
        double a = ReadDouble();
        double b = ReadDouble();
        double alpha = ReadDouble();

        // h = ((b-a)/2) * tan(alpha)
        double h = ((b - a) / 2.0) * Math.Tan(alpha);
        double s = (a + b) / 2.0 * h;

        Console.WriteLine($"{s:F6}");
    }
}
