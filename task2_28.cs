using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // 10..999, десятки != 0
        int b = n / 100;
        int ac = n % 100;
        int a = ac / 10;
        int c = ac % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
