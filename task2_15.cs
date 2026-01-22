using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!);
        int a = x / 100, b = (x / 10) % 10, c = x % 10;
        Console.WriteLine(b * 100 + a * 10 + c);
    }
}
