using System;
using System.Globalization;

class Program
{
    static double RD() => double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

    static void Main()
    {
        double a = RD(), b = RD(), c = RD(), d = RD();
        Console.WriteLine(a.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(b.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(c.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(d.ToString(CultureInfo.InvariantCulture));
    }
}
