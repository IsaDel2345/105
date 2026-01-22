using System;

class Program {
    static void Main() {
        // Ввод: a2 a1 b2 b1
        var p = Console.ReadLine()!.Split();
        int a2 = int.Parse(p[0]), a1 = int.Parse(p[1]);
        int b2 = int.Parse(p[2]), b1 = int.Parse(p[3]);

        int ones = a1 + b1;
        int carry = ones / 10;
        ones %= 10;

        int tens = a2 + b2 + carry; // по условию результат двузначный
        Console.WriteLine($"{tens} {ones}");
    }
}
