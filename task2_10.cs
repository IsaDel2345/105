using System;

class Program {
    static void Main() {
        int a = int.Parse(Console.ReadLine()!);
        int t = a / 10, u = a % 10;
        Console.WriteLine(u * 10 + t);
    }
}
