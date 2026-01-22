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
        // Ввод: e f g h (через Enter)
        double e = ReadDouble();
        double f = ReadDouble();
        double g = ReadDouble();
        double h = ReadDouble();

        double a = Math.Pow(Math.Abs(e - 3.0 / f), 0.75) + g; // (|e-3/f|^3)^(1/4) + g = |e-3/f|^(3/4) + g
        double b = Math.Sin(e) + Math.Pow(Math.Cos(h), 2);
        double c = 33.0 * g / (e * f - 3.0);

        Console.WriteLine($"a = {a:F6}");
        Console.WriteLine($"b = {b:F6}");
        Console.WriteLine($"c = {c:F6}");
    }
}
