using System;

class Program {
    static void Main() {
        int k = int.Parse(Console.ReadLine()!); // 1..365
        int n = (k - 1) % 7 + 1;               // 1..7
        Console.WriteLine(n == 7 ? 0 : n);     // 0 = воскресенье
    }
}
