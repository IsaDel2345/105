using System;
using System.Globalization;

class Program
{
    static double RD() => double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

    static void Main()
    {
        double a = RD(), b = RD(), c = RD();
        Console.WriteLine($"{a}  {b}  {c}");
    }
}
