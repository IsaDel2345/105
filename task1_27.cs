using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        const double R = 6350.0; // км
        double h = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double d = Math.Sqrt((R + h) * (R + h) - R * R);
        Console.WriteLine(d.ToString(CultureInfo.InvariantCulture));
    }
}
