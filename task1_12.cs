using System;

class Program
{
    static void Main()
    {
        // а)
        Console.WriteLine("5 10");
        Console.WriteLine("7 см");

        // б) ввод t, v
        int t = int.Parse(Console.ReadLine()!);
        int v = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"100 {t}");
        Console.WriteLine($"1949 {v}");

        // в) ввод x, y
        int x = int.Parse(Console.ReadLine()!);
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{x} 25");
        Console.WriteLine($"{x} {y}");
    }
}
