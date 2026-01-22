using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // n>9
        Console.WriteLine(n % 10); // единицы
        Console.WriteLine((n / 10) % 10); // десятки
    }
}
