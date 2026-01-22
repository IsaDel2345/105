using System;

class Program {
    static void Main() {
        var p = Console.ReadLine()!.Split();
        int a = int.Parse(p[0]);
        int b = int.Parse(p[1]);

        // bool -> 1/0 без if
        int ok = (Convert.ToInt32(a % b == 0) | Convert.ToInt32(b % a == 0));
        Console.WriteLine(ok == 1 ? 1 : 2); // "любое другое число" -> 2
    }
}
