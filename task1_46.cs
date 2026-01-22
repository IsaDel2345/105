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

        Console.WriteLine($"Сумма = {a + b:F6}");
        Console.WriteLine($"Разность a-b = {a - b:F6}");
        Console.WriteLine($"Произведение = {a * b:F6}");
        Console.WriteLine($"Частное a/b = {a / b:F6}");
    }
}
