using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double y = (a * a + 10) / (Math.Sqrt(a * a) + 1);
        Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
    }
}
