using System;
using System.Globalization;

class Program
{
    static double ReadDouble()
    {
        var s = Console.ReadLine()!.Trim().Replace(',', '.');
        return double.Parse(s, CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        // Ввод: a
        double a = ReadDouble();

        // Цепочки умножений (без Math.Pow), как в условии

        // a^4 (2)
        double a2 = a * a;          // 1
        double a4 = a2 * a2;        // 2

        // a^6 (3)
        double a3 = a2 * a;         // 2-я (для этого подпункта)
        double a6 = a3 * a3;        // 3-я

        // a^7 (4)
        double a7 = a6 * a;         // 4-я

        // a^8 (3) уже можно: a8 = a4*a4
        double a8 = a4 * a4;

        // a^9 (4): a9 = a8*a
        double a9 = a8 * a;

        // a^10 (4): a5 = a4*a, a10=a5*a5
        double a5 = a4 * a;
        double a10 = a5 * a5;

        // a^13 (5): a12=a6*a6, a13=a12*a
        double a12 = a6 * a6;
        double a13 = a12 * a;

        // a^15 (5): a15=a10*a5
        double a15 = a10 * a5;

        // a^21 (6): a14=a7*a7, a21=a14*a7
        double a14 = a7 * a7;
        double a21 = a14 * a7;

        // a^28 (6): a28=(a14)^2
        double a28 = a14 * a14;

        // a^64 (6): a2,a4,a8,a16,a32,a64
        double a16 = a8 * a8;
        double a32 = a16 * a16;
        double a64 = a32 * a32;

        Console.WriteLine($"a^4  = {a4}");
        Console.WriteLine($"a^6  = {a6}");
        Console.WriteLine($"a^7  = {a7}");
        Console.WriteLine($"a^8  = {a8}");
        Console.WriteLine($"a^9  = {a9}");
        Console.WriteLine($"a^10 = {a10}");
        Console.WriteLine($"a^13 = {a13}");
        Console.WriteLine($"a^15 = {a15}");
        Console.WriteLine($"a^21 = {a21}");
        Console.WriteLine($"a^28 = {a28}");
        Console.WriteLine($"a^64 = {a64}");
    }
}
