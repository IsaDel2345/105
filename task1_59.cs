using System;

class Program
{
    static void Main()
    {
        // 450°F -> °C
        double f = 450.0;
        double c = (f - 32.0) / 1.8;

        Console.WriteLine($"{c:F6}");
    }
}
