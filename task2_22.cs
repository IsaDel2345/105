using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // n>999
        Console.WriteLine((n / 100) % 10);  // сотни
        Console.WriteLine((n / 1000) % 10); // тысячи
    }
}
