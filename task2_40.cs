using System;

class Program {
    static void Main() {
        // y в радианах
        double y = double.Parse(Console.ReadLine()!);
        double yDeg = y * 180.0 / Math.PI;

        double totalMinutes = 2.0 * yDeg; // как в 2.40
        int hours = (int)(totalMinutes / 60.0);
        int minutes = (int)(totalMinutes % 60.0);

        double minuteAngleDeg = 6.0 * minutes;                 // минутная стрелка
        double minuteAngleRad = minuteAngleDeg * Math.PI / 180.0;

        Console.WriteLine(minuteAngleRad);
        Console.WriteLine(hours);
        Console.WriteLine(minutes);
    }
}
