using System;

class Program
{
    static void Main()
    {
        // а)
        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");

        // б) ввод a, b
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{a} 1");
        Console.WriteLine($"19 {b}");

        // в) ввод x, y
        int x = int.Parse(Console.ReadLine()!);
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{x} {y}");
        Console.WriteLine($"5 {y}");
    }
}
