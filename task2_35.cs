using System;

class Program {
    static void Main() {
        // Ввод: a3 a2 a1 b2 b1  (a - трехзначное, b - двузначное)
        var p = Console.ReadLine()!.Split();
        int a3 = int.Parse(p[0]), a2 = int.Parse(p[1]), a1 = int.Parse(p[2]);
        int b2 = int.Parse(p[3]), b1 = int.Parse(p[4]);

        int d1 = a1 + b1;
        int carry = d1 / 10; d1 %= 10;

        int d2 = a2 + b2 + carry;
        carry = d2 / 10; d2 %= 10;

        int d3 = a3 + carry; // по условию сумма трехзначная
        Console.WriteLine($"{d3} {d2} {d1}");
    }
}
