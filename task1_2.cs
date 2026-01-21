using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine(Math.E.ToString("F1", CultureInfo.InvariantCulture));
    }
}
