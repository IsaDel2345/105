using System;
using System.Globalization;

class Program
{
    static double RD() => double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

    static void Main()
    {
        // Введите "a" или "b"
        string p = Console.ReadLine()!.Trim().ToLowerInvariant();

        if (p == "a" || p == "а")
        {
            double x = RD();
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
        }
        else
        {
            double a = RD();
            double x = 12 * a * a + 7 * a - 16;
            Console.WriteLine(x.ToString(CultureInfo.InvariantCulture));
        }
    }
}
