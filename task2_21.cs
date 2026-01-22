using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // n>99
        Console.WriteLine((n / 10) % 10); // десятки
        Console.WriteLine((n / 100) % 10); // сотни
    }
}
