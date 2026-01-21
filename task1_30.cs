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
            double y = RD();
            double z = Math.Pow(x, 3) - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;
            Console.WriteLine(z.ToString(CultureInfo.InvariantCulture));
        }
        else
        {
            double a = RD();
            double b = RD();
            double x = 3.56 * a + Math.Pow(b, 3) - 5.8 * b * b + 3.8 * a - 1.5;
            Console.WriteLine(x.ToString(CultureInfo.InvariantCulture));
        }
    }
}
