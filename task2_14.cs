using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!);
        int c = x % 10, ab = x / 10;
        Console.WriteLine(c * 100 + ab);
    }
}
