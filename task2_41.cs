using System;

class Program {
    static double Mod360(double x) {
        x %= 360.0;
        if (x < 0) x += 360.0;
        return x;
    }

    static void Main() {
        var p = Console.ReadLine()!.Split();
        int h = int.Parse(p[0]); // 1..12
        int m = int.Parse(p[1]); // 0..59

        // углы в момент времени
        double hour0 = 30.0 * (h % 12) + 0.5 * m;
        double min0  = 6.0 * m;

        int tCoincide = -1;
        int tPerp = -1;

        for (int t = 0; t <= 720; t++) { // максимум 12 часов
            double hour = Mod360(hour0 + 0.5 * t);
            double min  = Mod360(min0  + 6.0 * t);

            double diff = Mod360(min - hour);

            if (tCoincide < 0 && (Math.Abs(diff - 0.0) < 1e-9 || Math.Abs(diff - 360.0) < 1e-9))
                tCoincide = t;

            if (tPerp < 0 && (Math.Abs(diff - 90.0) < 1e-9 || Math.Abs(diff - 270.0) < 1e-9))
                tPerp = t;

            if (tCoincide >= 0 && tPerp >= 0) break;
        }

        Console.WriteLine(tCoincide);
        Console.WriteLine(tPerp);
    }
}
