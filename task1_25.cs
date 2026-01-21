using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.WriteLine((4 * a).ToString(CultureInfo.InvariantCulture));
    }
}
