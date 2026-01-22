using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!); // четырехзначное (в т.ч. с 0 в середине)
        int a = x / 1000;
        int b = (x / 100) % 10;
        int c = (x / 10) % 10;
        int d = x % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine(a * b * c * d);
    }
}
