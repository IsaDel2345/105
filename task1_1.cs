using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
    }
}
