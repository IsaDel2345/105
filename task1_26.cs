using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.WriteLine((2 * r).ToString(CultureInfo.InvariantCulture));
    }
}

