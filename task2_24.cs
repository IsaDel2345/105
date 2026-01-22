using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // 10..999, десятки != 0
        int last = n / 100;
        int q = n % 100;
        int x = 100 * q + 11 * last;
        Console.WriteLine(x);
    }
}
