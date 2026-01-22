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
        // Ввод: a b c (ребра параллелепипеда)
        double a = ReadDouble();
        double b = ReadDouble();
        double c = ReadDouble();

        double v = a * b * c;
        double sSide = 2 * c * (a + b); // боковая поверхность

        Console.WriteLine($"Объем = {v:F6}");
        Console.WriteLine($"Площадь боковой поверхности = {sSide:F6}");
    }
}
