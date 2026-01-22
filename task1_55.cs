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
        // Ввод: X Y
        double x = ReadDouble();
        double y = ReadDouble();

        double avg = (x + y) / 2.0;

        Console.WriteLine($"Средний возраст = {avg:F6}");
        Console.WriteLine($"Таня отличается на = {Math.Abs(x - avg):F6}");
        Console.WriteLine($"Митя отличается на = {Math.Abs(y - avg):F6}");
    }
}
