using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // 1..999
        int a = n % 10;
        int bc = n / 10;
        int x = a * 100 + bc;
        Console.WriteLine(x);
    }
}
