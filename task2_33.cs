using System;

class Program {
    static void Main() {
        // Ввод: a2 a1 b (десятки, единицы, однозначное)
        var p = Console.ReadLine()!.Split();
        int a2 = int.Parse(p[0]);
        int a1 = int.Parse(p[1]);
        int b  = int.Parse(p[2]);

        int s1 = a1 + b;     // единицы суммы
        int carry = s1 / 10;
        s1 %= 10;

        int s2 = a2 + carry; // десятки суммы
        Console.WriteLine($"{s2} {s1}");
    }
}
