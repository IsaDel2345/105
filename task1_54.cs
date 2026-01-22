using System;
using System.Globalization;

class Program
{
    static double ReadDouble()
    {
        var s = Console.ReadLine()!.Trim().Replace(',', '.');
        return double.Parse(s, CultureInfo.InvariantCulture);
    }
    static int ReadInt() => int.Parse(Console.ReadLine()!.Trim());

    static void Main()
    {
        // Ввод: monitor systemBlock keyboard mouse N
        double m = ReadDouble();
        double sb = ReadDouble();
        double k = ReadDouble();
        double ms = ReadDouble();
        int n = ReadInt();

        double onePc = m + sb + k + ms;

        Console.WriteLine($"3 компьютера: {3 * onePc:F2}");
        Console.WriteLine($"{n} компьютеров: {n * onePc:F2}");
    }
}
