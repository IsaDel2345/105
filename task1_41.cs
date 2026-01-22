using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

        double x = (2.0 / (a * a + 25) + b) / (Math.Sqrt(b) + (a + b) / 2.0);
        double y = (Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a);

        Console.WriteLine(x.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
    }
}
