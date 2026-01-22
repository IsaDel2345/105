using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine()!);
        int hours = n / 3600;
        int minutes = (n % 3600) / 60;
        int seconds = n % 60;
        Console.WriteLine(hours);
        Console.WriteLine(minutes);
        Console.WriteLine(seconds);
    }
}
