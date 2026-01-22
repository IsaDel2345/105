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
        // Ввод: a b h (основания и высота равнобедренной трапеции)
        double a = ReadDouble(); // меньшее основание
        double b = ReadDouble(); // большее основание
        double h = ReadDouble();

        double leg = Math.Sqrt(h * h + Math.Pow((b - a) / 2.0, 2));
        double p = a + b + 2 * leg;

        Console.WriteLine($"{p:F6}");
    }
}
