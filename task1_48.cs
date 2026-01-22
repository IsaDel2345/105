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
        // Ввод: x1 y1 x2 y2
        double x1 = ReadDouble();
        double y1 = ReadDouble();
        double x2 = ReadDouble();
        double y2 = ReadDouble();

        double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        Console.WriteLine($"{dist:F6}");
    }
}
