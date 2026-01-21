using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double V = a * a * a;
        double Sbok = 4 * a * a;
        Console.WriteLine(V.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine(Sbok.ToString(CultureInfo.InvariantCulture));
    }
}
