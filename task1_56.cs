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
        // Ввод: V1 V2 S
        double v1 = ReadDouble();
        double v2 = ReadDouble();
        double s = ReadDouble();

        double t = s / (v1 + v2); // часы
        Console.WriteLine($"{t:F6}");
    }
}
