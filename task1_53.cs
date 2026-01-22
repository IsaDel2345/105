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
        // Ввод: priceCandy priceCookies priceApples x y z
        double pc = ReadDouble();
        double pp = ReadDouble();
        double pa = ReadDouble();
        double x = ReadDouble();
        double y = ReadDouble();
        double z = ReadDouble();

        double sum = pc * x + pp * y + pa * z;
        Console.WriteLine($"{sum:F6}");
    }
}
