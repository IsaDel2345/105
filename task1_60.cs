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
        // Ввод: a b
        double a = ReadDouble();
        double b = ReadDouble();

        double tmp = a;
        a = b;
        b = tmp;

        Console.WriteLine($"a = {a:F6}");
        Console.WriteLine($"b = {b:F6}");
    }
}
