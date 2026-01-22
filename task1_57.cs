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
        // Ввод: V1 V2 S (V1 > V2)
        double v1 = ReadDouble();
        double v2 = ReadDouble();
        double s = ReadDouble();

        double t = 0.5; // 30 минут = 0.5 часа
        double dist = s + (v1 - v2) * t;

        Console.WriteLine($"{dist:F6}");
    }
}
