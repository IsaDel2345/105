using System;
using System.Globalization;

class Program
{
    static double ReadDouble()
    {
        var s = Console.ReadLine()!.Trim().Replace(',', '.');
        return double.Parse(s, CultureInfo.InvariantCulture);
    }

    static double Dist(double x1, double y1, double x2, double y2)
        => Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

    static void Main()
    {
        // Ввод: x1 y1 x2 y2 x3 y3
        double x1 = ReadDouble(); double y1 = ReadDouble();
        double x2 = ReadDouble(); double y2 = ReadDouble();
        double x3 = ReadDouble(); double y3 = ReadDouble();

        double a = Dist(x1, y1, x2, y2);
        double b = Dist(x2, y2, x3, y3);
        double c = Dist(x3, y3, x1, y1);

        double p = a + b + c;
        double s = Math.Abs(
            (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0
        );

        Console.WriteLine($"Периметр = {p:F6}");
        Console.WriteLine($"Площадь = {s:F6}");
    }
}
