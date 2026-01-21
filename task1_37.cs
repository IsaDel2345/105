using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double R = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double r = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double S = Math.PI * (R * R - r * r);
        Console.WriteLine(S.ToString(CultureInfo.InvariantCulture));
    }
}
