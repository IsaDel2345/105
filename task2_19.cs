using System;

class Program {
    static void Main() {
        int x = int.Parse(Console.ReadLine()!); // четырехзначное
        int a = x / 1000;
        int b = (x / 100) % 10;
        int c = (x / 10) % 10;
        int d = x % 10;

        // а)
        int rev = d * 1000 + c * 100 + b * 10 + a;
        Console.WriteLine(rev);

        // б) (1<->2) и (3<->4)
        int swap12_34 = b * 1000 + a * 100 + d * 10 + c;
        Console.WriteLine(swap12_34);

        // в) (2<->3)
        int swap23 = a * 1000 + c * 100 + b * 10 + d;
        Console.WriteLine(swap23);

        // г) (12<->34)
        int swap12with34 = c * 1000 + d * 100 + a * 10 + b;
        Console.WriteLine(swap12with34);
    }
}
