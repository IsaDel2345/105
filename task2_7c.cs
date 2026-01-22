using System;

class Program {
    static void Main() {
        var p = Console.ReadLine()!.Split();
        int k = int.Parse(p[0]);
        int d = int.Parse(p[1]); // 1..7
        int day = ((d - 1) + (k - 1)) % 7 + 1; // 1..7
        Console.WriteLine(day == 7 ? 0 : day);
    }
}
