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

        double a = (e + f / 2.0) / 3.0;
        double b = Math.Abs(h * h - g);
        double c = Math.Sqrt((g - h) * (g - h) - 3.0 * Math.Sin(e));

        Console.WriteLine($"a = {a:F6}");
        Console.WriteLine($"b = {b:F6}");
        Console.WriteLine($"c = {c:F6}");
    }
}
