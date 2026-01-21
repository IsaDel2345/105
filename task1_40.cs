using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double y = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

        double z = (x + (2 + y) / (x * x)) / (y + 1.0 / Math.Sqrt(x * x + 10));
        double q = 2.8 * Math.Sin(x) + Math.Abs(y);

        Console.WriteLine(z.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(q.ToString(CultureInfo.InvariantCulture));
    }
}
