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
        // Ввод: a b c
        double a = ReadDouble();
        double b = ReadDouble();
        double c = ReadDouble();

        // Вариант (а): b <- c, a <- b, c <- a (по смыслу — циклический сдвиг вправо)
        {
            double aa = a, bb = b, cc = c;
            double t = aa;
            aa = bb;
            bb = cc;
            cc = t;
            Console.WriteLine("Вариант (а):");
            Console.WriteLine($"a = {aa:F6}");
            Console.WriteLine($"b = {bb:F6}");
            Console.WriteLine($"c = {cc:F6}");
        }

        // Вариант (б): b <- a, c <- b, a <- c (по смыслу — циклический сдвиг влево)
        {
            double aa = a, bb = b, cc = c;
            double t = aa;
            aa = cc;
            cc = bb;
            bb = t;
            Console.WriteLine("Вариант (б):");
            Console.WriteLine($"a = {aa:F6}");
            Console.WriteLine($"b = {bb:F6}");
            Console.WriteLine($"c = {cc:F6}");
        }
    }
}
