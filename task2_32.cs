using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!); // 1..999, единицы != 0
        int c = n / 100;
        int ba = n % 100;
        int b = ba / 10;
        int a = ba % 10;
        int x = a * 100 + b * 10 + c;
        Console.WriteLine(x);
    }
}
