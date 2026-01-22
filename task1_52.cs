using System;
using System.Globalization;

class Program
{
    static double ReadDouble()
    {
        var s = Console.ReadLine()!.Trim().Replace(',', '.');
        return double.Parse(s, CultureInfo.InvariantCulture);
    }

    static double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        => Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;

    static void Main()
    {
        // Ввод: x1 y1 x2 y2 x3 y3 x4 y4 (выпуклый четырехугольник по порядку обхода)
        double x1 = ReadDouble(); double y1 = ReadDouble();
        double x2 = ReadDouble(); double y2 = ReadDouble();
        double x3 = ReadDouble(); double y3 = ReadDouble();
        double x4 = ReadDouble(); double y4 = ReadDouble();

        // Разбиваем диагональю (1-3): (1,2,3) и (1,3,4)
        double s = TriangleArea(x1, y1, x2, y2, x3, y3) + TriangleArea(x1, y1, x3, y3, x4, y4);

        Console.WriteLine($"{s:F6}");
    }
}
