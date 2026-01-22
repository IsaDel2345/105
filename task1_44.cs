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
        double x = ReadDouble();
        double y = ReadDouble();

        double ax = Math.Abs(x);
        double ay = Math.Abs(y);

        double arith = (ax + ay) / 2.0;
        double geom = Math.Sqrt(ax * ay);

        Console.WriteLine($"Среднее арифметическое = {arith:F6}");
        Console.WriteLine($"Среднее геометрическое  = {geom:F6}");
    }
}
