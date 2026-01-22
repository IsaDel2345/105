using System;

class Program {
    static void Main() {
        int k = int.Parse(Console.ReadLine()!);
        int n = (k % 7) + 1;      // сдвиг на 1 день
        if (n == 8) n = 1;
        Console.WriteLine(n == 7 ? 0 : n);
    }
}
