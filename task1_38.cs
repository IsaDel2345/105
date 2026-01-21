using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double c = Math.Sqrt(a * a + b * b);
        double P = a + b + c;
        Console.WriteLine(P.ToString(CultureInfo.InvariantCulture));
    }
}
