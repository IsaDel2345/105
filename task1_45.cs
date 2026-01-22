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
        // Ввод: a b (стороны прямоугольника)
        double a = ReadDouble();
        double b = ReadDouble();

        double p = 2 * (a + b);
        double d = Math.Sqrt(a * a + b * b);

        Console.WriteLine($"Периметр = {p:F6}");
        Console.WriteLine($"Диагональ = {d:F6}");
    }
}
