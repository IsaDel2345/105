using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!); // трехзначное
        int a = x / 100;
        int b = (x / 10) % 10;
        int c = x % 10;
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a + b + c);
        Console.WriteLine(a * b * c);
    }
}
