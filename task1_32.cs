using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double V = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double m = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.WriteLine((m / V).ToString(CultureInfo.InvariantCulture));
    }
}
