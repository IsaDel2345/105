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

        // a) a^3 и a^10
        {
            double a2 = a * a;          // 1
            double a3 = a2 * a;         // 2
            double a5 = a3 * a2;        // 3
            double a10 = a5 * a5;       // 4
            Console.WriteLine("a) a^3, a^10");
            Console.WriteLine($"a^3  = {a3}");
            Console.WriteLine($"a^10 = {a10}");
        }

        // б) a^4 и a^20
        {
            double a2 = a * a;          // 1
            double a4 = a2 * a2;        // 2
            double a5 = a4 * a;         // 3
            double a10 = a5 * a5;       // 4
            double a20 = a10 * a10;     // 5
            Console.WriteLine("б) a^4, a^20");
            Console.WriteLine($"a^4  = {a4}");
            Console.WriteLine($"a^20 = {a20}");
        }

        // в) a^5 и a^13
        {
            double a2 = a * a;          // 1
            double a4 = a2 * a2;        // 2
            double a5 = a4 * a;         // 3
            double a8 = a4 * a4;        // 4
            double a13 = a8 * a5;       // 5
            Console.WriteLine("в) a^5, a^13");
            Console.WriteLine($"a^5  = {a5}");
            Console.WriteLine($"a^13 = {a13}");
        }

        // г) a^5 и a^19 (в тексте указано 5 операций, но надежная цепочка дает 6 умножений)
        {
            double a2 = a * a;          // 1
            double a4 = a2 * a2;        // 2
            double a5 = a4 * a;         // 3
            double a10 = a5 * a5;       // 4
            double a15 = a10 * a5;      // 5
            double a19 = a15 * a4;      // 6
            Console.WriteLine("г) a^5, a^19");
            Console.WriteLine($"a^5  = {a5}");
            Console.WriteLine($"a^19 = {a19}");
        }

        // д) a^2, a^5, a^17
        {
            double a2 = a * a;          // 1
            double a4 = a2 * a2;        // 2
            double a5 = a4 * a;         // 3
            double a10 = a5 * a5;       // 4
            double a15 = a10 * a5;      // 5
            double a17 = a15 * a2;      // 6
            Console.WriteLine("д) a^2, a^5, a^17");
            Console.WriteLine($"a^2  = {a2}");
            Console.WriteLine($"a^5  = {a5}");
            Console.WriteLine($"a^17 = {a17}");
        }

        // е) a^4, a^12, a^28
        {
            double a2 = a * a;          // 1
            double a4 = a2 * a2;        // 2
            double a8 = a4 * a4;        // 3
            double a12 = a8 * a4;       // 4
            double a24 = a12 * a12;     // 5
            double a28 = a24 * a4;      // 6
            Console.WriteLine("е) a^4, a^12, a^28");
            Console.WriteLine($"a^4  = {a4}");
            Console.WriteLine($"a^12 = {a12}");
            Console.WriteLine($"a^28 = {a28}");
        }
    }
}
