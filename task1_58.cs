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
        // Ввод: tC
        double c = ReadDouble();

        double f = c * 1.8 + 32.0;
        double k = c + 273.15;

        Console.WriteLine($"F = {f:F6}");
        Console.WriteLine($"K = {k:F6}");
    }
}
