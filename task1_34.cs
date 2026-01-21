using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        double S = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.WriteLine((n / S).ToString(CultureInfo.InvariantCulture));
    }
}
