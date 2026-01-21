using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double h = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

        double leg = Math.Sqrt(Math.Pow((A - B) / 2.0, 2) + h * h);
        double P = A + B + 2 * leg;

        Console.WriteLine(P.ToString(CultureInfo.InvariantCulture));
    }
}
