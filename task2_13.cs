using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!);
        int a = x / 100, bc = x % 100;
        Console.WriteLine(bc * 10 + a);
    }
}
