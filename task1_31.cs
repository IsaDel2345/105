using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        double ar = (a + b) / 2.0;
        double geo = Math.Sqrt((double)a * b);

        Console.WriteLine(ar.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(geo.ToString(CultureInfo.InvariantCulture));
    }
}
