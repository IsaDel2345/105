using System;

class Program {
    static void Main() {
        double y = double.Parse(Console.ReadLine()!); // 0 <= y < 360
        double totalMinutes = 2.0 * y;                // 0.5°/мин => минут = y/0.5
        int hours = (int)(totalMinutes / 60.0);
        int minutes = (int)(totalMinutes % 60.0);
        Console.WriteLine(hours);
        Console.WriteLine(minutes);
    }
}
