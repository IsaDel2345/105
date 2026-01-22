using System;

class Program {
    static void Main() {
        var p = Console.ReadLine()!.Split();
        int h = int.Parse(p[0]);
        int m = int.Parse(p[1]);
        int s = int.Parse(p[2]);

        int totalSeconds = h * 3600 + m * 60 + s;
        double angle = (totalSeconds / 120.0) % 360.0; // 360° за 43200с
        Console.WriteLine(angle);
    }
}
