using System;

class Program {
    static void Main() {
        // Из условия: получилось 237
        int n = 237;
        int last = n / 100;      // приписанная последняя цифра x
        int q = n % 100;         // частное (x - last)/10
        int x = 100 * q + 11 * last;
        Console.WriteLine(x);
    }
}
