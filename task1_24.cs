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
            double a = RD();
            double x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);
            Console.WriteLine(x.ToString(CultureInfo.InvariantCulture));
        }
        else
        {
            double x = RD();
            double y = Math.Sin((3.2 + Math.Sqrt(1 + x)) / Math.Abs(5 * x));
            Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
        }
    }
}
