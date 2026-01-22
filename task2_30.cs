using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // 100..999
        int ac = n / 10;
        int b = n % 10;
        int a = ac / 10;
        int c = ac % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
