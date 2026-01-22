using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!);
        int x = (n % 12) + 1; // месяц (1..12)
        Console.WriteLine(x);
    }
}
