using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double L = 2 * Math.PI * r;
        double S = Math.PI * r * r;
        Console.WriteLine(L.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(S.ToString(CultureInfo.InvariantCulture));
    }
}
